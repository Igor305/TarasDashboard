﻿using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using HtmlAgilityPack;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace BusinessLogicLayer.Services
{
    public class BoardService : IBoardService
    {
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _configuration;

        private readonly IShopsRepository _shopsRepository;
        private readonly IRegionsLocalizationRepository _regionsLocalizationRepository;
        private readonly ISaleOracleRepository _saleOracleRepository;
        private readonly ISaleStatisticRepository _saleStatisticRepository;
        private readonly ISaleLast30Days_ByRegionRepository _saleLast30Days_ByRegionRepository;
        private readonly IExecutionPlanDate_HistoryRepository _executionPlanDate_HistoryRepository;
        private readonly IPlanSaleStockOnDateRepository _planSaleStockOnDateRepository;
        private readonly IPlanSaleStockOnDateDRepository _planSaleStockOnDateDRepository;


        public BoardService(IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration, IShopsRepository shopsRepository, IRegionsLocalizationRepository regionsLocalizationRepository, 
                            ISaleOracleRepository saleOracleRepository, ISaleStatisticRepository saleStatisticRepository, ISaleLast30Days_ByRegionRepository saleLast30Days_ByRegionRepository,
                            IExecutionPlanDate_HistoryRepository executionPlanDate_HistoryRepository, IPlanSaleStockOnDateRepository planSaleStockOnDateRepository, IPlanSaleStockOnDateDRepository planSaleStockOnDateDRepository)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _configuration = configuration;

            _shopsRepository = shopsRepository;
            _regionsLocalizationRepository = regionsLocalizationRepository;
            _saleOracleRepository = saleOracleRepository;
            _saleStatisticRepository = saleStatisticRepository;
            _saleLast30Days_ByRegionRepository = saleLast30Days_ByRegionRepository;
            _executionPlanDate_HistoryRepository = executionPlanDate_HistoryRepository;
            _planSaleStockOnDateRepository = planSaleStockOnDateRepository;
            _planSaleStockOnDateDRepository = planSaleStockOnDateDRepository;
        }

        public SaleResponseModel getStaticSale()
        {
            SaleResponseModel saleResponseModel = _memoryCache.Get<SaleResponseModel>("responseModel");

            return saleResponseModel;
        }

        public async Task getSaleInCache()
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Minute == 0)
            {
                try
                {
                    SaleOracleModel saleOracleModel = await getSaleOracle();

                    List<SaleStatisticModel> saleStatisticModels = await getSaleStatistic();

                    List<SaleRegionsModel> saleRegionsModels = await getSaleRegions();

                    SaleRegionsModel lastLines = addLastLine(saleRegionsModels);

                    List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels = await getExecutionPlan();

                    List<DiagramModel> diagramModels = getDiagramValue(executionPlanDate_HistoryModels);

                    List<PlanSaleStockOnDateModel> planSaleStockOnDateModels = await getPlanSaleStockOnDate();

                    string date = DateTime.Now.ToShortDateString();
                    string time = DateTime.Now.ToShortTimeString();

                    SaleResponseModel saleResponseModel = new SaleResponseModel();

                    saleResponseModel.saleOracleModel = saleOracleModel;
                    saleResponseModel.saleStatisticModels = saleStatisticModels;
                    saleResponseModel.saleRegionsModels = saleRegionsModels;
                    saleResponseModel.lastLines = lastLines;
                    saleResponseModel.executionPlanDate_HistoryModels = executionPlanDate_HistoryModels;
                    saleResponseModel.diagramModels = diagramModels;
                    saleResponseModel.planSaleStockOnDateModels = planSaleStockOnDateModels;
                    saleResponseModel.Date = date;
                    saleResponseModel.Time = time;
                    saleResponseModel.Status = true;
                    saleResponseModel.Message = "successfully";

                    _memoryCache.Set("responseModel", saleResponseModel, new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(3)
                    });

                    await sendInTelegram(saleResponseModel, executionPlanDate_HistoryModels, diagramModels, planSaleStockOnDateModels);
                }

                catch (Exception e)
                {
                    SaleResponseModel saleResponseModel = new SaleResponseModel();
                    saleResponseModel.Status = false;
                    saleResponseModel.Message = e.Message;

                    string token = _configuration["TelegramBot:Token"];

                    TelegramBotClient botClient;

                    botClient = new TelegramBotClient(token);

                    await botClient.SendTextMessageAsync(
                       chatId: _configuration["TelegramBot:CreatorId"],
                       text: e.Message
                       );
                }
            }      
        }

        private async Task sendInTelegram(SaleResponseModel saleResponseModel, List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels, List<DiagramModel> diagramModels, List<PlanSaleStockOnDateModel> planSaleStockOnDateModels)
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Hour == 10 || dateTime.Hour == 13 || dateTime.Hour == 17 || dateTime.Hour == 21)
            {
                string token = _configuration["TelegramBot:Token"];

                TelegramBotClient botClient;

                botClient = new TelegramBotClient(token);

                createPhoto1(saleResponseModel, executionPlanDate_HistoryModels);
                createPhoto2(saleResponseModel);
                createPhoto3(saleResponseModel);
                createPhoto4(diagramModels, executionPlanDate_HistoryModels, planSaleStockOnDateModels);

                string message = $"данные на {dateTime.ToShortTimeString()} {dateTime.ToShortDateString()}";
                
                await botClient.SendTextMessageAsync(
                   chatId: _configuration["TelegramBot:ChannelId"],
                   text: message
                   );            

                await sendPhoto(botClient, "Photo1.jpeg");
                await sendPhoto(botClient, "Photo2.jpeg");
                await sendPhoto(botClient, "Photo3.jpeg");
                await sendPhoto(botClient, "Photo4.jpeg");
            }
        }

        private async Task sendPhoto(TelegramBotClient botClient, string path)
        {

            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                await botClient.SendPhotoAsync(
                    chatId: _configuration["TelegramBot:ChannelId"],
                    photo: fileStream
                    );
            }
        }

        private void createPhoto1(SaleResponseModel saleResponseModel, List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels)
        {
            Bitmap bitmap = new Bitmap(1920, 1080);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Image newImage = Image.FromFile("ClientApp/dist/assets/background_1.png");

                float x = 0.0F;
                float y = 0.0F;

                RectangleF srcRect = new RectangleF(0.0F, 0.0F, 1920.0F, 1080.0F);
                GraphicsUnit units = GraphicsUnit.Pixel;

                graphic.DrawImage(newImage, x, y, srcRect, units);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    graphic.FillRectangle(brush, 30, 30, 1860, 1020);

                }

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(18, 156, 18)))
                {
                    graphic.FillRectangle(brush, 50, 50, 930, 320);

                }

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(211, 211, 211)))
                {
                    graphic.FillRectangle(brush, 50, 380, 930, 320);

                }

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(211, 211, 211)))
                {
                    graphic.FillRectangle(brush, 50, 710, 930, 320);

                }
                
                Pen pen = new Pen(Color.FromArgb(18, 156, 18),20);

                DateTime dateTime = DateTime.Now;

                dateTime = DateTime.Now.AddDays(-1);

                float arc = 0;
                decimal planDate = 0;
                decimal chainFactToDate = 0;
                decimal chainPlanToDate = 0;

                foreach (ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel in executionPlanDate_HistoryModels){
                    if (dateTime.Date == executionPlanDate_HistoryModel.Dates)
                    {
                        planDate = Math.Truncate(executionPlanDate_HistoryModel.ExecutionPlanToDatePercent ?? 0);
                        arc = float.Parse((planDate * 360 / 100).ToString());

                        chainFactToDate = Math.Round((executionPlanDate_HistoryModel.ChainFactToDate ?? 0) /1000000, 2);
                        chainPlanToDate = Math.Round((executionPlanDate_HistoryModel.ChainPlanToDate ?? 0) /1000000, 2);
                    }
                }

                graphic.DrawArc(pen, new Rectangle(1180, 100, 550, 550), 270, arc);

                Font font = new Font("Helvetica Neue", 105, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);

                x = 100;
                y = 130;

                graphic.DrawString($"{saleResponseModel.saleOracleModel.Real} ({Math.Round(saleResponseModel.saleOracleModel.Oracle, 1)})", font, drawBrush, x, y);

                x = 120;
                y = 440;

                drawBrush = new SolidBrush(Color.Black);

                font = new Font("Helvetica Neue", 115, FontStyle.Bold);

                graphic.DrawString("СЧ:", font, drawBrush, x, y);

                x = 390;
                y = 440;

                font = new Font("Helvetica Neue", 115, FontStyle.Bold);

                graphic.DrawString(Math.Round(saleResponseModel.saleOracleModel.AvgCheck, 2).ToString(), font, drawBrush, x, y);

                x = 200;
                y = 770;

                font = new Font("Helvetica Neue", 115, FontStyle.Bold);

                graphic.DrawString(Math.Round(saleResponseModel.saleOracleModel.RecFor7Day, 2).ToString(), font, drawBrush, x, y);

                font = new Font("Helvetica Neue", 100);

                x = 1280;
                y = 310;

                graphic.DrawString($"{planDate}%", font, drawBrush, x, y);

                font = new Font("Helvetica Neue", 90);

                x = 990;
                y = 800;

                if (chainFactToDate < 100) x += 50;
                if (chainPlanToDate < 100) x += 50;

                graphic.DrawString($"{chainFactToDate}({chainPlanToDate})", font, drawBrush, x, y);
            }
            bitmap.Save("Photo1.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void createPhoto2(SaleResponseModel saleResponseModel)
        {
            Bitmap bitmap = new Bitmap(1920, 1080);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Image newImage = Image.FromFile("ClientApp/dist/assets/background_1.png");

                int x = 0;
                int y = 0;

                RectangleF srcRect = new RectangleF(0.0F, 0.0F, 1920.0F, 1080.0F);
                GraphicsUnit units = GraphicsUnit.Pixel;

                graphic.DrawImage(newImage, x, y, srcRect, units);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    graphic.FillRectangle(brush, 30, 30, 1860, 1020);
                }

                Font font = new Font("Helvetica Neue", 45, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                x = 180;
                y = 30;

                graphic.DrawString("Дата", font, drawBrush, x, y);

                x = 480;
                y = 30;

                graphic.DrawString("Р", font, drawBrush, x, y);

                x = 730;
                y = 30;

                graphic.DrawString("СЧ", font, drawBrush, x, y);

                x = 1000;
                y = 30;

                graphic.DrawString("ОП", font, drawBrush, x, y);

                x = 1300;
                y = 30;

                graphic.DrawString("М", font, drawBrush, x, y);

                x = 1500;
                y = 30;

                graphic.DrawString("О", font, drawBrush, x, y);

                x = 1680;
                y = 30;

                graphic.DrawString("LFL", font, drawBrush, x, y);
  
                int count = 1;
                int height = 110;
                y = 120;


                foreach (SaleStatisticModel saleStatisticModel in saleResponseModel.saleStatisticModels)
                {
                    if (count % 2 == 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                        {
                            graphic.FillRectangle(brush, 65, height, 1800, 65);

                            height += 65;
                        }
                    }

                    if (count % 2 != 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(221, 221, 221)))
                        {
                            graphic.FillRectangle(brush, 65, height, 1800, 65);

                            height += 65;
                        }
                    }

                    count++;

                    font = new Font("Helvetica Neue", 35);

                    drawBrush = new SolidBrush(Color.Black);

                    int xDate = 150;
                    int xP = 450;
                    int xCH = 720;
                    int xOP = 1000;
                    int xM = 1290;
                    int xO = 1500;
                    int xLFL = 1680;
                    if (saleStatisticModel.LFL <= 9 && saleStatisticModel.LFL > 0)
                    {
                        xLFL = 1695;
                    }
 
                    graphic.DrawString(saleStatisticModel.DateOfString, font, drawBrush, xDate, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.TsumCc_Wt,2).ToString(), font, drawBrush, xP, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.AvgCheck,2).ToString(), font, drawBrush, xCH, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Rec,2).ToString(), font, drawBrush, xOP, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Margin,2).ToString(), font, drawBrush, xM, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Turnover,0).ToString(), font, drawBrush, xO, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.LFL ?? 0, 2).ToString(), font, drawBrush, xLFL, y);

                    y += 65;
                }
            }

            bitmap.Save("Photo2.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void createPhoto3(SaleResponseModel saleResponseModel)
        {
            Bitmap bitmap = new Bitmap(1920, 1080);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Image newImage = Image.FromFile("ClientApp/dist/assets/background_1.png");

                float x = 0.0F;
                float y = 0.0F;

                RectangleF srcRect = new RectangleF(0.0F, 0.0F, 1920.0F, 1080.0F);
                GraphicsUnit units = GraphicsUnit.Pixel;

                graphic.DrawImage(newImage, x, y, srcRect, units);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    graphic.FillRectangle(brush, 30, 30, 1860, 1020);
                }

                Font font = new Font("Helvetica Neue", 35, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                x = 580;
                y = 40;

                graphic.DrawString("Pop", font, drawBrush, x, y);

                x = 880;
                y = 40;

                graphic.DrawString("NoS", font, drawBrush, x, y);

                x = 1180;
                y = 40;

                graphic.DrawString("PpS", font, drawBrush, x, y);

                x = 1550;
                y = 40;

                graphic.DrawString("Sa/P-30", font, drawBrush, x, y);

                int height = 115;
                int count = 1;
                y = 120;

                double maxSalesForOnePeople = 0;

                foreach (SaleRegionsModel saleRegionsModel in saleResponseModel.saleRegionsModels)
                {
                    if (maxSalesForOnePeople < saleRegionsModel.SalesForOnePeople)
                    {
                        maxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                    }
                }

                foreach (SaleRegionsModel saleRegionsModel in saleResponseModel.saleRegionsModels)
                {
                    if (count % 2 == 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                        {
                            graphic.FillRectangle(brush, 60, height, 1800, 35);

                            height += 35;
                        }
                    }

                    if (count % 2 != 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(221, 221, 221)))
                        {
                            graphic.FillRectangle(brush, 60, height, 1800, 35);

                            height += 35;
                        }
                    }

                    count++;

                    font = new Font("Helvetica Neue", 18);

                    drawBrush = new SolidBrush(Color.Black);

                    float xName = 260;
                    float xPop = 620;
                    float xNoS = 920;
                    float xPpS = 1220;
                    float xSa = 1620;

                    xName = centeringName(xName, saleRegionsModel.Name);

                    graphic.DrawString(saleRegionsModel.Name, font, drawBrush, xName, y);

                    xPop = centering(xPop, saleRegionsModel.Population);

                    graphic.DrawString(Math.Round(saleRegionsModel.Population,2).ToString(), font, drawBrush, xPop, y);

                    xNoS = centering(xNoS, saleRegionsModel.NumberTT);

                    graphic.DrawString(Math.Round(saleRegionsModel.NumberTT,2).ToString(), font, drawBrush, xNoS, y);

                    xPpS = centering(xPpS, saleRegionsModel.PopulationForOneTT);

                    graphic.DrawString(Math.Round(saleRegionsModel.PopulationForOneTT,2).ToString(), font, drawBrush, xPpS, y);

                    double percent = saleRegionsModel.SalesForOnePeople * 100 /maxSalesForOnePeople;
                    
                    if (percent >= 0 && percent < 20) { drawBrush = new SolidBrush(Color.FromArgb(232, 42, 45)); }
                    if (percent >= 20 && percent < 40) { drawBrush = new SolidBrush(Color.FromArgb(248, 113, 115)); }
                    if (percent >= 40 && percent < 60) { drawBrush = new SolidBrush(Color.FromArgb(0, 0, 0)); }
                    if (percent >= 60 && percent < 80) { drawBrush = new SolidBrush(Color.FromArgb(96, 198, 123)); }
                    if (percent >= 80 && percent <= 100) { drawBrush = new SolidBrush(Color.FromArgb(28, 154, 61)); }

                    xSa = centering(xSa, saleRegionsModel.SalesForOnePeople);

                    graphic.DrawString(Math.Round(saleRegionsModel.SalesForOnePeople, 2).ToString(), font, drawBrush, xSa, y);

                    y += 35;
                }

                font = new Font("Helvetica Neue", 21);

                drawBrush = new SolidBrush(Color.Black);

                x = 590;
                y = 1000;

                graphic.DrawString(Math.Round(saleResponseModel.lastLines.Population,2).ToString(), font, drawBrush, x, y);

                x = 910;
                y = 1000;

                graphic.DrawString(Math.Round(saleResponseModel.lastLines.NumberTT, 2).ToString(), font, drawBrush, x, y);

                x = 1200;
                y = 1000;

                graphic.DrawString(Math.Round(saleResponseModel.lastLines.PopulationForOneTT, 2).ToString(), font, drawBrush, x, y);

                x = 1580;
                y = 1000;

                graphic.DrawString(Math.Round(saleResponseModel.lastLines.SalesForOnePeople, 2).ToString(), font, drawBrush, x, y);

            }

           bitmap.Save("Photo3.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public void createPhoto4(List<DiagramModel> diagramModels, List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels, List<PlanSaleStockOnDateModel> planSaleStockOnDateModels)
        {
            Bitmap bitmap = new Bitmap(1920, 1090);
            using (Graphics graphic = Graphics.FromImage(bitmap))
            {
                Image newImage = Image.FromFile("ClientApp/dist/assets/background_1.png");

                int x = 0;
                int y = 0;

                RectangleF srcRect = new RectangleF(0.0F, 0.0F, 1920.0F, 1080.0F);
                GraphicsUnit units = GraphicsUnit.Pixel;

                graphic.DrawImage(newImage, x, y, srcRect, units);

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                {
                    graphic.FillRectangle(brush, 10, 10, 1900, 1060);
                }

                Pen gray = new Pen(Color.FromArgb(212, 212, 212), 1);

                int x1 = 50;
                int y1 = 20;
                int x2 = 1890;
                int y2 = 20;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                y1 = y2 = 140;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                y1 = y2 = 260;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                y1 = y2 = 380;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                y1 = y2 = 500;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                y1 = y2 = 620;

                graphic.DrawLine(gray, x1, y1, x2, y2);

                DateTime dateTime = DateTime.Now;

                if (dateTime.Day == 1)
                {
                    dateTime = dateTime.AddDays(-1);
                }

                int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
                string month = "";

                if (dateTime.Month < 10)
                {
                    month = $"0{dateTime.Month}";
                }
                else
                {
                    month = $"{dateTime.Month}";
                }

                x = 50;
                int count = 0;

                Font font = new Font("Helvetica Neue", 14);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Fact

                foreach (DiagramModel diagramModel in diagramModels)
                {
                    count++;

                    font = new Font("Helvetica Neue", 14);

                    drawBrush = new SolidBrush(Color.Black);
                    if (count != 1)
                    {
                        x += 60;
                    }

                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(38, 160, 252)))
                    {
                        int value = int.Parse(Math.Round(((diagramModel.Value ?? 0) / 100000), 0).ToString());

                        if (value != 0)
                        {
                            double scale = Math.Round(value * 1.2);
                            value = int.Parse(scale.ToString());
                        }

                        int temporarily = 600 - value;
                        if (value == 0)
                        {
                            temporarily = 600;
                        }

                        graphic.FillRectangle(brush, x + 5, 600 - value + 20, 35, 600 - temporarily);
                    }

                    y = 630;

                    graphic.DrawString($"{count}.{month}", font, drawBrush, x, y);
                }

                y = 610;

                int millions = 0;

                for (int z = 0; z <= 5; z++)
                {
                    font = new Font("Helvetica Neue", 14);

                    drawBrush = new SolidBrush(Color.Black);

                    if (z != 0)
                    {
                        millions += 10;
                        y -= 120;
                    }

                    x = 20;

                    graphic.DrawString($"{millions}", font, drawBrush, x, y);
                }

                x = 50;
                count = 0;
                int previousPlan = 0;

                // Plan

                foreach (DiagramModel diagramModel in diagramModels)
                {
                    count++;

                    if (count == 1)
                    {
                        previousPlan = int.Parse(Math.Round(((diagramModel.Plan ?? 0) / 100000), 0).ToString());

                        double scale = Math.Round(previousPlan * 1.2);
                        previousPlan = int.Parse(scale.ToString());

                        Pen penElipce = new Pen(Color.FromArgb(38, 231, 166), 5);

                        Rectangle rect = new Rectangle(x + 20, 600 - previousPlan + 18, 5, 5);

                        graphic.DrawEllipse(penElipce, rect);

                        SolidBrush blueBrush = new SolidBrush(Color.FromArgb(38, 231, 166));
                        rect = new Rectangle(x + 5, 590 - previousPlan, 35, 20);
                        graphic.FillRectangle(blueBrush, rect);

                        font = new Font("Helvetica Neue", 12);
                        drawBrush = new SolidBrush(Color.Black);

                        decimal pl = Math.Round(((diagramModel.Plan ?? 0) / 1000000), 1);

                        graphic.DrawString((pl).ToString(), font, drawBrush, x + 5, 590 - previousPlan);

                        font = new Font("Helvetica Neue", 12);
                        drawBrush = new SolidBrush(Color.Black);

                        decimal fact = Math.Round(((diagramModel.Value ?? 0) / 1000000), 1);

                        graphic.DrawString((fact).ToString(), font, drawBrush, x + 5, 650 - previousPlan);

                    }

                    if (count != 1)
                    {

                        int plan = int.Parse(Math.Round(((diagramModel.Plan ?? 0) / 100000), 0).ToString());

                        if (plan != 0)
                        {
                            x += 60;

                            double scale = Math.Round(plan * 1.2);
                            plan = int.Parse(scale.ToString());

                            Pen pen = new Pen(Color.FromArgb(38, 231, 166), 3);

                            PointF point1 = new PointF(x - 35, 600 - previousPlan + 20);
                            PointF point2 = new PointF(x + 25, 600 - plan + 20);

                            graphic.DrawLine(pen, point1, point2);

                            Pen penElipce = new Pen(Color.FromArgb(38, 231, 166), 5);
                            Rectangle rect = new Rectangle(x + 20, 600 - plan + 18, 5, 5);

                            graphic.DrawEllipse(penElipce, rect);

                            SolidBrush brush = new SolidBrush(Color.FromArgb(38, 231, 166));
                            rect = new Rectangle(x + 5, 590 - plan, 35, 20);

                            graphic.FillRectangle(brush, rect);

                            font = new Font("Helvetica Neue", 12);
                            drawBrush = new SolidBrush(Color.Black);

                            decimal pl = Math.Round(((diagramModel.Plan ?? 0) / 1000000), 1);

                            graphic.DrawString((pl).ToString(), font, drawBrush, x + 5, 590 - plan);

                            font = new Font("Helvetica Neue", 12);
                            drawBrush = new SolidBrush(Color.Black);

                            decimal fact = Math.Round(((diagramModel.Value ?? 0) / 1000000), 1);

                            graphic.DrawString((fact).ToString(), font, drawBrush, x + 5, 680 - plan);

                            previousPlan = plan;
                        }
                    }
                }

                // Future Plan

                foreach (PlanSaleStockOnDateModel planSaleStockOnDateModel in planSaleStockOnDateModels)
                {
                    x += 60;

                    int plan = int.Parse(Math.Round((planSaleStockOnDateModel.PlanSum / 100000), 0).ToString());

                    double scale = Math.Round(plan * 1.2);
                    plan = int.Parse(scale.ToString());

                    Pen pen = new Pen(Color.FromArgb(38, 231, 166), 3);

                    PointF point1 = new PointF(x - 35, 600 - previousPlan + 20);
                    PointF point2 = new PointF(x + 25, 600 - plan + 20);

                    graphic.DrawLine(pen, point1, point2);

                    Pen penElipce = new Pen(Color.FromArgb(38, 231, 166), 5);
                    Rectangle rect = new Rectangle(x + 20, 600 - plan + 18, 5, 5);

                    graphic.DrawEllipse(penElipce, rect);

                    SolidBrush brush = new SolidBrush(Color.FromArgb(38, 231, 166));
                    rect = new Rectangle(x + 5, 590 - plan, 35, 20);

                    graphic.FillRectangle(brush, rect);

                    font = new Font("Helvetica Neue", 12);
                    drawBrush = new SolidBrush(Color.Black);

                    decimal pl = Math.Round((planSaleStockOnDateModel.PlanSum / 1000000), 1);

                    graphic.DrawString((pl).ToString(), font, drawBrush, x + 5, 590 - plan);

                    previousPlan = plan;

                }

                Pen elipce = new Pen(Color.FromArgb(38, 160, 252), 10);
                Rectangle rectangle = new Rectangle(850, 670, 10, 10);

                graphic.DrawEllipse(elipce, rectangle);

                font = new Font("Helvetica Neue", 15);
                drawBrush = new SolidBrush(Color.Black);

                graphic.DrawString("Факт", font, drawBrush, 880, 665);

                elipce = new Pen(Color.FromArgb(38, 231, 166), 10);
                rectangle = new Rectangle(950, 670, 10, 10);

                graphic.DrawEllipse(elipce, rectangle);

                font = new Font("Helvetica Neue", 15);
                drawBrush = new SolidBrush(Color.Black);

                graphic.DrawString("План", font, drawBrush, 970, 665);

                font = new Font("Helvetica Neue", 21, FontStyle.Bold);
                drawBrush = new SolidBrush(Color.Black);

                x = 100;
                y = 700;

                graphic.DrawString("Дата", font, drawBrush, x, y);

                x = 300;
                y = 700;

                graphic.DrawString("К-во ТТ", font, drawBrush, x, y);

                x = 525;
                y = 700;

                graphic.DrawString("План выручки", font, drawBrush, x, y);

                x = 840;
                y = 700;

                graphic.DrawString("Факт выручки", font, drawBrush, x, y);

                x = 1180;
                y = 700;

                graphic.DrawString("Выполнение, %", font, drawBrush, x, y);

                x = 1550;
                y = 700;

                graphic.DrawString("Выполнение", font, drawBrush, x, y);

                List<ExecutionPlanDate_HistoryModel> executionPlanDateModels = new List<ExecutionPlanDate_HistoryModel>();

                foreach (ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel in executionPlanDate_HistoryModels)
                {
                    if (executionPlanDate_HistoryModel.Dates > dateTime.AddDays(-8) && executionPlanDate_HistoryModel.Dates <= dateTime)
                    {
                        executionPlanDateModels.Add(executionPlanDate_HistoryModel);
                    }
                }

                executionPlanDateModels.Reverse();

                int height = 750;
                y = 755;

                foreach (ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel in executionPlanDateModels)
                {
                    if (count % 2 == 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 255)))
                        {
                            graphic.FillRectangle(brush, 40, height, 1840, 40);

                            height += 40;
                        }
                    }

                    if (count % 2 != 0)
                    {
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(221, 221, 221)))
                        {
                            graphic.FillRectangle(brush, 40, height, 1840, 40);

                            height += 40;
                        }
                    }

                    count++;

                    font = new Font("Helvetica Neue", 18);

                    drawBrush = new SolidBrush(Color.Black);

                    int xDate = 80;
                    int xCount = 325;
                    int xPlan = 560;
                    int xFact = 885;
                    int xExecutionPercent = 1250;
                    int xExecution = 1590;

                    string chainPlanDay = formatingHistory(Math.Round(executionPlanDate_HistoryModel.ChainPlanDay ?? 0, 2));
                    string chainFactDay = formatingHistory(Math.Round(executionPlanDate_HistoryModel.ChainFactDay ?? 0, 2));
                    string execution = formatingHistory(Math.Round(executionPlanDate_HistoryModel.ExecutionPlanDayUah ?? 0, 0));

                    graphic.DrawString(executionPlanDate_HistoryModel.DateString, font, drawBrush, xDate, y);
                    graphic.DrawString(executionPlanDate_HistoryModel.StocksQty.ToString(), font, drawBrush, xCount, y);
                    graphic.DrawString(chainPlanDay, font, drawBrush, xPlan, y);
                    graphic.DrawString(chainFactDay, font, drawBrush, xFact, y);
                    graphic.DrawString(Math.Round(executionPlanDate_HistoryModel.ExecutionPlanDayPercent ?? 0, 2).ToString(), font, drawBrush, xExecutionPercent, y);
                    graphic.DrawString(execution, font, drawBrush, xExecution, y);

                    y += 40;
                }

            }

            bitmap.Save("Photo4.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private float centeringName (float x, string name)
        {
            int length = name.Length;

            if (name == "Чернігівська")
            {
                x = x - 6 * (length-1);
            }
            else
            {
                x = x - 6 * (length);
            }
            return x;
        }
        private float centering(float x, double salesForOnePeople)
        {            
            if (salesForOnePeople >= 100 && salesForOnePeople < 1000) { x += 0; }
            if (salesForOnePeople >= 10 && salesForOnePeople < 100) { x += 5; }
            if (salesForOnePeople > 0 && salesForOnePeople < 10) { x += 10; }
            if (salesForOnePeople == 0) { x += 10; }
            if (salesForOnePeople % 1 != 0) { x -= 20; }

            return x;
        }

        private async Task<SaleOracleModel> getSaleOracle()
        {
            List<IpSaleOracle> ipSaleOracles = await _saleOracleRepository.getSaleOracleProcedure();

            List<SaleOracleModel> saleOracleModels = _mapper.Map<List<IpSaleOracle>, List<SaleOracleModel>>(ipSaleOracles);

            SaleOracleModel saleOracleModel = saleOracleModels[0];

            return saleOracleModel;
        }

        private async Task<List<SaleStatisticModel>> getSaleStatistic()
        {

            List<SaleStatistic> saleStatistics = await _saleStatisticRepository.getSaleStatistic();

            List<SaleStatisticModel> saleStatisticModels = _mapper.Map<List<SaleStatistic>, List<SaleStatisticModel>>(saleStatistics);

            foreach (SaleStatisticModel saleStatisticModel in saleStatisticModels)
            {
                saleStatisticModel.Turnover = Math.Round(saleStatisticModel.Turnover);

                string month = "";

                switch (saleStatisticModel.DateOfData.Month)
                {
                    case 1: month = "січня"; break;
                    case 2: month = "лютого"; break;
                    case 3: month = "березня"; break;
                    case 4: month = "квітня"; break;
                    case 5: month = "травня"; break;
                    case 6: month = "червня"; break;
                    case 7: month = "липня"; break;
                    case 8: month = "серпня"; break;
                    case 9: month = "вересня"; break;
                    case 10: month = "жовтня"; break;
                    case 11: month = "листопада"; break;
                    case 12: month = "грудня"; break;
                }

                saleStatisticModel.DateOfString = $"{saleStatisticModel.DateOfData.Day} {month}";
            }

            return saleStatisticModels;
        }

        private async Task<List<SaleRegionsModel>> getSaleRegions()
        {
            List<Shop> shops = await _shopsRepository.getCountTT();
            List<RegionsLocalization> regionsLocalizations = await _regionsLocalizationRepository.getRegions();

            List<ShopModel> shopsModels = _mapper.Map<List<Shop>, List<ShopModel>>(shops);
            List<RegionsLocalizationModel> regionsLocalizationModels = _mapper.Map<List<RegionsLocalization>, List<RegionsLocalizationModel>>(regionsLocalizations);

            List<PopulationRegionModel> numberTT = new List<PopulationRegionModel>();

            for (int x = 0; x < regionsLocalizationModels.Count; x++)
            {
                numberTT.Add(new PopulationRegionModel
                {
                    Name = regionsLocalizationModels[x].Name,
                    Population = 0
                });              
            }      

            PopulationRegionModel[] numTT = numberTT.ToArray();

            foreach (ShopModel shopModel in shopsModels)
            {
                for (int x = 1; x <= regionsLocalizationModels.Count; x++)
                {
                    if (shopModel.RegionId == x)
                    {
                        if(shopModel.RegionId == 9)
                        {

                        }
                        numTT[x-1].Population++;
                    }
                }
            }

            List<IpSaleLast30Days_ByRegion> ipSaleLast30Days_ByRegions = await _saleLast30Days_ByRegionRepository.getSaleLast30Days_ByRegion();

            List<SaleLast30Days_ByRegionModel> saleLast30Days_ByRegionModels = _mapper.Map<List<IpSaleLast30Days_ByRegion>, List<SaleLast30Days_ByRegionModel>>(ipSaleLast30Days_ByRegions);

            List<PopulationRegionModel> populationRegionModels = new List<PopulationRegionModel>();

            List<double> populations = parsing();

            populationRegionModels.Add(new PopulationRegionModel{Name = "Вінницька", Population = populations[0] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Волинська", Population = populations[1] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Дніпропетровська", Population = populations[2] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Донецька", Population = populations[3] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Житомирська", Population = populations[4] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Закарпатська", Population = populations[5] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Запорізька", Population = populations[6] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Івано-Франківська", Population = populations[7] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київ", Population = populations[24] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київська", Population = populations[8] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Кіровоградська", Population = populations[9] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Луганська", Population = populations[10] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Львівська", Population = populations[11] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Миколаївська", Population = populations[12] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Одеська", Population = populations[13] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Полтавська", Population = populations[14] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Рівненська", Population = populations[15] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Сумська", Population = populations[16] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Тернопільська", Population = populations[17] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Харківська", Population = populations[18] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Херсонська", Population = populations[19] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Хмельницька", Population = populations[20] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Черкаська", Population = populations[21] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернівецька", Population = populations[22] });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернігівська", Population = populations[23] });

            List<PopulationRegionModel> populationForOneTT = new List<PopulationRegionModel>();
            List<PopulationRegionModel> salesForOnePeoples = new List<PopulationRegionModel>();

            for (int x = 0; x < numTT.Length; x++)
            {
                if (populationRegionModels[x].Name == numTT[x].Name)
                {
                    if (numTT[x].Population == 0)
                    {
                        populationForOneTT.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = 0 });
                        salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = 0 });
                    }

                    else
                    {
                        double populationRegion = populationRegionModels[x].Population / numTT[x].Population;
                        populationRegion = Math.Round(populationRegion, 2);
                        populationForOneTT.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = populationRegion });

                        int count = 0;

                        foreach (SaleLast30Days_ByRegionModel saleLast30Days_ByRegionModel in saleLast30Days_ByRegionModels)
                        {

                            if (numTT[x].Name == saleLast30Days_ByRegionModel.RegionName)
                            {
                                count = 1;
                                double salesForOnePeople = saleLast30Days_ByRegionModel.SaleSum / populationRegionModels[x].Population;
                                salesForOnePeople = Math.Round(salesForOnePeople, 2);
                                salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = salesForOnePeople });
                            }                        
                        }

                        if (count != 1)
                        {
                            double salesForOnePeople = 0;
                            salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = salesForOnePeople });
                        }
                    }
                }                          
            }

            List<SaleRegionsModel> saleRegionsModels = new List<SaleRegionsModel>();

            for (int i = 0; i < numTT.Length; i++)
            {
                if (i < saleLast30Days_ByRegionModels.Count)
                {
                    saleRegionsModels.Add(new SaleRegionsModel
                    {
                        Name = numTT[i].Name,
                        Population = Math.Round(populationRegionModels[i].Population / 1000000, 2),
                        NumberTT = numTT[i].Population,
                        PopulationForOneTT = Math.Round(populationForOneTT[i].Population / 1000, 2),
                        SalesInThe30Days = Math.Round(saleLast30Days_ByRegionModels[i].SaleSum / 1000000, 2),
                        SalesForOnePeople = salesForOnePeoples[i].Population
                    });
                }

                if (i >= saleLast30Days_ByRegionModels.Count)
                {
                    saleRegionsModels.Add(new SaleRegionsModel
                    {
                        Name = numTT[i].Name,
                        Population = Math.Round(populationRegionModels[i].Population / 1000000, 2),
                        NumberTT = numTT[i].Population,
                        PopulationForOneTT = Math.Round(populationForOneTT[i].Population / 1000, 2),
                        SalesInThe30Days = 0,
                        SalesForOnePeople = salesForOnePeoples[i].Population
                    });
                }
            }

            saleRegionsModels = getPercentsSalesForOnePeople(saleRegionsModels);

            return saleRegionsModels;
        }

        private List<double> parsing()
        {
            List<double> populations = new List<double>();

            string html = @"https://index.minfin.com.ua/reference/people/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            for (int x = 3; x < 28; x++)
            {
                var value = htmlDoc.DocumentNode.SelectSingleNode($"//*[@id='sort-table']/table/tr[{x}]/td[5]");

                string text = value.OuterHtml;

                text = text.Substring(27);
                text = text.Substring(0, text.Length - 5);

                double population = Math.Truncate(double.Parse(text) * 1000);

                populations.Add(population);
            }

            return populations;
        }

        private List<SaleRegionsModel> getPercentsSalesForOnePeople(List<SaleRegionsModel> saleRegionsModels)
        {
            double maxSalesForOnePeople = 0;

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                if (maxSalesForOnePeople < saleRegionsModel.SalesForOnePeople)
                {
                    maxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }
            }

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                saleRegionsModel.PercentSalesForOnePeople = saleRegionsModel.SalesForOnePeople * 100 / maxSalesForOnePeople;
            }

            return saleRegionsModels;
        }

        private SaleRegionsModel addLastLine(List<SaleRegionsModel> saleRegionsModels)
        {
            SaleRegionsModel lastLineModel = new SaleRegionsModel();

            double lastPopulation = 0;
            double lastNumberTT = 0;
            double lastPopulationForOneTT = 0;
            double lastSalesForOnePeople = 0;

            double maxSalesForOnePeople = 0;
            double beforeMaxSalesForOnePeople = 0;

            foreach (SaleRegionsModel saleRegionsModel in saleRegionsModels)
            {
                lastPopulation += saleRegionsModel.Population;
                lastNumberTT += saleRegionsModel.NumberTT;

                if (maxSalesForOnePeople < saleRegionsModel.SalesForOnePeople)
                {
                    maxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }

                if (beforeMaxSalesForOnePeople < saleRegionsModel.SalesForOnePeople && saleRegionsModel.SalesForOnePeople != maxSalesForOnePeople)
                {
                    beforeMaxSalesForOnePeople = saleRegionsModel.SalesForOnePeople;
                }
            }

            lastPopulation = Math.Round(lastPopulation, 2);
            lastPopulationForOneTT = Math.Round(lastPopulation * 1000000 / lastNumberTT / 1000, 2);
            lastSalesForOnePeople = Math.Round((beforeMaxSalesForOnePeople / 30)* lastPopulation * 365, 2);

            lastLineModel.Name = "";
            lastLineModel.NumberTT = lastNumberTT;
            lastLineModel.Population = lastPopulation;
            lastLineModel.PopulationForOneTT = lastPopulationForOneTT;
            lastLineModel.SalesInThe30Days = 0;
            lastLineModel.SalesForOnePeople = lastSalesForOnePeople;

            return lastLineModel;
        }

        public byte[] getExcel(List<SaleRegionsModel> saleRegionsModels)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {

                try
                { 
                    ExcelWorksheet ws = excel.Workbook.Worksheets.Add("Sale By Regions");

                    ws.Cells["B1"].Value = "Pop";
                    ws.Cells["C1"].Value = "NoS";
                    ws.Cells["D1"].Value = "PpS";
                    ws.Cells["E1"].Value = "Sa/P30";
                    ws.Cells["B1:E1"].Style.Font.Bold = true;

                    int x = 2;
                    foreach (SaleRegionsModel saleRegionsModel in  saleRegionsModels)
                    {
                        ws.Cells[$"A{x}"].Value = saleRegionsModel.Name;
                        ws.Cells[$"B{x}"].Value = saleRegionsModel.Population;
                        ws.Cells[$"C{x}"].Value = saleRegionsModel.NumberTT;
                        ws.Cells[$"D{x}"].Value = saleRegionsModel.PopulationForOneTT;
                        ws.Cells[$"E{x}"].Value = saleRegionsModel.SalesForOnePeople;

                        x++;
                    }
                }

                catch
                {

                }

            FileInfo excelFile = new FileInfo("Sale By Regions.xlsx");
            excel.SaveAs(excelFile);

            return excel.GetAsByteArray();
             
            }
        }

        private async Task<List<ExecutionPlanDate_HistoryModel>> getExecutionPlan()
        {
            List<ExecutionPlanDateHistory> executionPlanDateHistories = await _executionPlanDate_HistoryRepository.getAllForThisMonth();

            List<ExecutionPlanDate_HistoryModel> executionPlanDate_HistoryModels = _mapper.Map<List<ExecutionPlanDateHistory>, List<ExecutionPlanDate_HistoryModel>>(executionPlanDateHistories);

            foreach (ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel in executionPlanDate_HistoryModels)
            {
               
                executionPlanDate_HistoryModel.ChainPlanDay = Math.Round(executionPlanDate_HistoryModel.ChainPlanDay ?? 0, 0);
                executionPlanDate_HistoryModel.ChainFactDay = Math.Round(executionPlanDate_HistoryModel.ChainFactDay ?? 0, 0);
                executionPlanDate_HistoryModel.ExecutionPlanDayUah = Math.Round(executionPlanDate_HistoryModel.ExecutionPlanDayUah ?? 0, 0);
                executionPlanDate_HistoryModel.ExecutionPlanDayPercent = Math.Round(executionPlanDate_HistoryModel.ExecutionPlanDayPercent ?? 0, 2);

                executionPlanDate_HistoryModel.DateString = executionPlanDate_HistoryModel.Dates.ToShortDateString();

                executionPlanDate_HistoryModel.diagramModel.Name = executionPlanDate_HistoryModel.Dates;
                executionPlanDate_HistoryModel.diagramModel.Value = executionPlanDate_HistoryModel.ChainFactDay;
                executionPlanDate_HistoryModel.diagramModel.Plan = executionPlanDate_HistoryModel.ChainPlanDay;

                executionPlanDate_HistoryModel.ChainPlanDayString = formatingHistory(executionPlanDate_HistoryModel.ChainPlanDay);
                executionPlanDate_HistoryModel.ChainFactDayString = formatingHistory(executionPlanDate_HistoryModel.ChainFactDay);
                executionPlanDate_HistoryModel.ExecutionPlanDayUahString = formatingHistory(executionPlanDate_HistoryModel.ExecutionPlanDayUah);
                
            }

            return executionPlanDate_HistoryModels;
        }

        private string formatingHistory(decimal? value)
        {
            string result = "";
            bool minus = false;

            if (value < 0)
            {
                minus = true;
                value = Math.Abs(value ?? 0);
            }

            decimal? valueThousand = value / 1000;
            valueThousand = Math.Truncate(valueThousand ?? 0);

            if (valueThousand > 0)
            {

                decimal? valueMillion = valueThousand / 1000;
                valueMillion = Math.Truncate(valueMillion ?? 0);

                if (valueMillion > 0)
                {
                    decimal? valueBillion = valueMillion / 1000;
                    valueBillion = Math.Truncate(valueBillion ?? 0);

                    if (valueBillion > 0)
                    {
                        valueBillion = Math.Truncate((valueMillion ?? 0) / 1000);
                        valueMillion = Math.Truncate((valueThousand ?? 0) / 1000);
                        string valueMillionString = returningZeros(valueMillion);
                        valueThousand = Math.Truncate((value ?? 0) / 1000);
                        string valueThousandString = returningZeros(valueThousand);
                        value %= 1000;
                        string valueString = returningZeros(value);
                        result += $"{valueBillion} {valueMillionString} {valueThousandString} {valueString}";
                    }

                    if(valueBillion <= 0)
                    {
                        valueMillion = Math.Truncate((valueThousand ?? 0) / 1000);
                        valueThousand = Math.Truncate((value ?? 0) / 1000 % 1000);
                        string valueThousandString = returningZeros(valueThousand);
                        value %= 1000;
                        string valueString = returningZeros(value);
                        result += $"{valueMillion} {valueThousandString} {valueString}";
                    }
                }

                if (valueMillion <= 0)
                {
                    valueThousand = Math.Truncate((value ?? 0) / 1000);
                    value %= 1000;
                    string valueString = returningZeros(value);
                    result += $"{valueThousand} {valueString}";
                }
            }

            if (valueThousand <= 0)
            {
                result += $"{value}";
            }

            if (minus)
            {
                result = result.Insert(0, "-");
            }

            return  result;
        }

        private string returningZeros(decimal? value)
        {
            string result = "";

            if (value >= 0 && value < 10)
            {
                result = $"00{value}";
            }
            if (value >= 10 && value < 100)
            {
                result = $"0{value}";
            }
            if (value >= 100 && value < 1000)
            {
                result = $"{value}";
            }

            return result;
        }

        private List<DiagramModel> getDiagramValue(List<ExecutionPlanDate_HistoryModel>  executionPlanDate_HistoryModels)
        {
            List<DiagramModel> diagramModels = new List<DiagramModel>();

            DateTime dateTime = DateTime.Now;
            
            if (dateTime.Day == 1)
            {
                dateTime = dateTime.AddDays(-1);
            }

            int days = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);

            executionPlanDate_HistoryModels.Reverse();

            foreach (ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel in executionPlanDate_HistoryModels)
            {
                diagramModels.Add(executionPlanDate_HistoryModel.diagramModel);
            }

            for (int x = dateTime.Day; x <= days; x++)
            {
                ExecutionPlanDate_HistoryModel executionPlanDate_HistoryModel = new ExecutionPlanDate_HistoryModel();

                DateTime date = new DateTime(dateTime.Year, dateTime.Month, x);

                executionPlanDate_HistoryModel.diagramModel.Name = date;
                executionPlanDate_HistoryModel.diagramModel.Value = 0;
                executionPlanDate_HistoryModel.diagramModel.Plan = 0;

                diagramModels.Add(executionPlanDate_HistoryModel.diagramModel);
            }

            return diagramModels;
        }

        public async Task<List<PlanSaleStockOnDateModel>> getPlanSaleStockOnDate()
        {
            List<PlanSaleStockOnDateModel> planSaleStockOnDateModels = new List<PlanSaleStockOnDateModel>();

            DateTime today = DateTime.Now;

            if (today.Day == 1)
            {
                return planSaleStockOnDateModels;
            }

            var days = DateTime.DaysInMonth(today.Year, today.Month);
            DateTime lastDay = new DateTime(today.Year, today.Month, days);

            List<ItPlanSaleStockOnDate> itPlanSaleStockOnDates = await _planSaleStockOnDateRepository.getPlanSaleStocksToMonth(today, lastDay);
            List<ItPlanSaleStockOnDateModel> itPlanSaleStockOnDateModels = _mapper.Map<List<ItPlanSaleStockOnDate>, List<ItPlanSaleStockOnDateModel>>(itPlanSaleStockOnDates);

            if (itPlanSaleStockOnDateModels.Count == 0)
            {
                return planSaleStockOnDateModels;
            }

            var firstPlan = itPlanSaleStockOnDateModels.First();
            var lastPlan = itPlanSaleStockOnDateModels.Last();

            List<ItPlanSaleStockOnDateD> itPlanSaleStockOnDateDs = await _planSaleStockOnDateDRepository.getPlanSaleStocksOnDateD(firstPlan.ChId, lastPlan.ChId);
            List<ItPlanSaleStockOnDateDModel> itPlanSaleStockOnDateDModels = _mapper.Map<List<ItPlanSaleStockOnDateD>, List<ItPlanSaleStockOnDateDModel>>(itPlanSaleStockOnDateDs);

            long chId = itPlanSaleStockOnDateDModels.First().ChId;
            DateTime date = new DateTime();
            decimal PlanSum = 0;

            foreach (ItPlanSaleStockOnDateDModel itPlanSaleStockOnDateDModel in itPlanSaleStockOnDateDModels)
            {
                if (chId != itPlanSaleStockOnDateDModel.ChId)
                {
                    foreach (ItPlanSaleStockOnDateModel itPlanSaleStockOnDateModel in itPlanSaleStockOnDateModels)
                    {
                        if (itPlanSaleStockOnDateModel.ChId == chId)
                        {
                            date = itPlanSaleStockOnDateModel.DocDate;
                            break;
                        }
                    }

                    planSaleStockOnDateModels.Add(new PlanSaleStockOnDateModel
                    {
                        Date = date,
                        PlanSum = PlanSum
                    });

                    PlanSum = 0;
                }

                if (chId == itPlanSaleStockOnDateDModel.ChId)
                {
                    PlanSum += Math.Round(itPlanSaleStockOnDateDModel.PlanSum,0);
                }
               
                chId = itPlanSaleStockOnDateDModel.ChId;
            }

            planSaleStockOnDateModels.Add(new PlanSaleStockOnDateModel
            {
                Date = date.AddDays(1),
                PlanSum = PlanSum
            });

            return planSaleStockOnDateModels;
        }
    }
}
