﻿using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        public BoardService(IMapper mapper, IMemoryCache memoryCache, IConfiguration configuration, IShopsRepository shopsRepository, IRegionsLocalizationRepository regionsLocalizationRepository, 
                            ISaleOracleRepository saleOracleRepository, ISaleStatisticRepository saleStatisticRepository, ISaleLast30Days_ByRegionRepository saleLast30Days_ByRegionRepository)
        {
            _mapper = mapper;
            _memoryCache = memoryCache;
            _configuration = configuration;

            _shopsRepository = shopsRepository;
            _regionsLocalizationRepository = regionsLocalizationRepository;
            _saleOracleRepository = saleOracleRepository;
            _saleStatisticRepository = saleStatisticRepository;
            _saleLast30Days_ByRegionRepository = saleLast30Days_ByRegionRepository;
        }

        public SaleResponseModel getStaticSale()
        {
            SaleResponseModel saleResponseModel = _memoryCache.Get<SaleResponseModel>("responseModel");

            return saleResponseModel;
        }

        public async Task getSaleInCache()
        {
            try
            {
                SaleOracleModel saleOracleModel = await getSaleOracle();

                List<SaleStatisticModel> saleStatisticModels = await getSaleStatistic();

                List<SaleRegionsModel> saleRegionsModels = await getSaleRegions();

                SaleRegionsModel lastLines = addLastLine(saleRegionsModels);

                string date = DateTime.Now.ToShortDateString();
                string time = DateTime.Now.ToShortTimeString();

                SaleResponseModel saleResponseModel = new SaleResponseModel();

                saleResponseModel.saleOracleModel = saleOracleModel;
                saleResponseModel.saleStatisticModels = saleStatisticModels;
                saleResponseModel.saleRegionsModels = saleRegionsModels;
                saleResponseModel.lastLines = lastLines;
                saleResponseModel.Date = date;
                saleResponseModel.Time = time;
                saleResponseModel.Status = true;
                saleResponseModel.Message = "successfully";

                _memoryCache.Set("responseModel", saleResponseModel, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(3)
                });

                await sendInTelegram(saleResponseModel);
            }

            catch (Exception e)
            {
                SaleResponseModel saleResponseModel = new SaleResponseModel();
                saleResponseModel.Status = false;
                saleResponseModel.Message = e.Message;

                string token = _configuration["TelegramBot:Token"];

                TelegramBotClient botClient;

                botClient = new TelegramBotClient(token);

                botClient.StartReceiving();

                await botClient.SendTextMessageAsync(
                   chatId: _configuration["TelegramBot:CreatorId"],
                   text: e.Message
                   );
            }
        }

        private async Task sendInTelegram(SaleResponseModel saleResponseModel)
        {
            DateTime dateTime = DateTime.Now;

            if (dateTime.Hour == 9 || dateTime.Hour == 13 || dateTime.Hour == 17 || dateTime.Hour == 21)
            {
                string token = _configuration["TelegramBot:Token"];

                TelegramBotClient botClient;

                botClient = new TelegramBotClient(token);

                botClient.StartReceiving();

                createPhoto1(saleResponseModel);
                createPhoto2(saleResponseModel);
                createPhoto3(saleResponseModel);

                await sendPhoto(botClient, "Photo1.jpeg");
                await sendPhoto(botClient, "Photo2.jpeg");
                await sendPhoto(botClient, "Photo3.jpeg");
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

        private void createPhoto1(SaleResponseModel saleResponseModel)
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

                float arc = saleResponseModel.saleOracleModel.PercentOnlineStock * 360 / 100;

                graphic.DrawArc(pen, new Rectangle(1000, 100, 850, 850), 270, arc);


                Font font = new Font("Helvetica Neue", 113, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.White);

                x = 110;
                y = 130;

                graphic.DrawString($"{saleResponseModel.saleOracleModel.Real} ({Math.Round(saleResponseModel.saleOracleModel.Oracle, 1)})", font, drawBrush, x, y);

                x = 130;
                y = 440;

                drawBrush = new SolidBrush(Color.Black);

                font = new Font("Helvetica Neue", 115);

                graphic.DrawString("СЧ:", font, drawBrush, x, y);

                x = 390;
                y = 440;

                font = new Font("Helvetica Neue", 115, FontStyle.Bold);

                graphic.DrawString(Math.Round(saleResponseModel.saleOracleModel.AvgCheck, 2).ToString(), font, drawBrush, x, y);

                x = 200;
                y = 770;

                font = new Font("Helvetica Neue", 115);

                graphic.DrawString(Math.Round(saleResponseModel.saleOracleModel.RecFor7Day, 2).ToString(), font, drawBrush, x, y);

                x = 1250;
                y = 450;

                graphic.DrawString($"{saleResponseModel.saleOracleModel.PercentOnlineStock}% ", font, drawBrush, x, y);
            }
            bitmap.Save("Photo1.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void createPhoto2(SaleResponseModel saleResponseModel)
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

                Font font = new Font("Helvetica Neue", 45, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                x = 180;
                y = 30;

                graphic.DrawString("Дата", font, drawBrush, x, y);

                x = 610;
                y = 30;

                graphic.DrawString("Р", font, drawBrush, x, y);

                x = 900;
                y = 30;

                graphic.DrawString("СЧ", font, drawBrush, x, y);

                x = 1200;
                y = 30;

                graphic.DrawString("ОП", font, drawBrush, x, y);

                x = 1510;
                y = 30;

                graphic.DrawString("М", font, drawBrush, x, y);

                x = 1700;
                y = 30;

                graphic.DrawString("О", font, drawBrush, x, y);

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
                    int xP = 590;
                    int xCH = 890;
                    int xOP = 1190;
                    int xM = 1500;
                    int xO = 1700;

                    graphic.DrawString(saleStatisticModel.DateOfString, font, drawBrush, xDate, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.TSumCC_wt,2).ToString(), font, drawBrush, xP, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.AvgCheck,2).ToString(), font, drawBrush, xCH, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Rec,2).ToString(), font, drawBrush, xOP, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Margin,2).ToString(), font, drawBrush, xM, y);
                    graphic.DrawString(Math.Round(saleStatisticModel.Turnover,0).ToString(), font, drawBrush, xO, y);

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

            List<IpSaleStatistic> ipSaleStatistics = await _saleStatisticRepository.getSaleStatistic();

            List<SaleStatisticModel> saleStatisticModels = _mapper.Map<List<IpSaleStatistic>, List<SaleStatisticModel>>(ipSaleStatistics);

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
                        numTT[x-1].Population++;
                    }
                }
            }

            List<IpSaleLast30Days_ByRegion> ipSaleLast30Days_ByRegions = await _saleLast30Days_ByRegionRepository.getSaleLast30Days_ByRegion();

            List<SaleLast30Days_ByRegionModel> saleLast30Days_ByRegionModels = _mapper.Map<List<IpSaleLast30Days_ByRegion>, List<SaleLast30Days_ByRegionModel>>(ipSaleLast30Days_ByRegions);

            List<PopulationRegionModel> populationRegionModels = new List<PopulationRegionModel>();

            populationRegionModels.Add(new PopulationRegionModel{Name = "Вінницька", Population = 1522100 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Волинська", Population = 1025800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Дніпропетровська", Population = 3127600 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Донецька", Population = 4088300 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Житомирська", Population = 1189800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Закарпатська", Population = 1247700 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Запорізька", Population = 1658300 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Івано-Франківська", Population = 1357200 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київ", Population = 2954000 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Київська", Population = 1787500 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Кіровоградська", Population = 914900 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Луганська", Population = 2115800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Львівська", Population = 2490000 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Миколаївська", Population = 1102800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Одеська", Population = 2361700 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Полтавська", Population = 1365500 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Рівненська", Population = 1146400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Сумська", Population = 1048000 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Тернопільська", Population = 1027400 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Харківська", Population = 2622800 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Херсонська", Population = 1012300 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Хмельницька", Population = 1238600 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Черкаська", Population = 1172700 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернівецька", Population = 894600 });
            populationRegionModels.Add(new PopulationRegionModel{Name = "Чернігівська", Population = 970900 });

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

                        foreach (SaleLast30Days_ByRegionModel saleLast30Days_ByRegionModel in saleLast30Days_ByRegionModels)
                        {
                            if (numTT[x].Name == saleLast30Days_ByRegionModel.RegionName)
                            {
                                double salesForOnePeople = saleLast30Days_ByRegionModel.SaleSum / populationRegionModels[x].Population;
                                salesForOnePeople = Math.Round(salesForOnePeople, 2);
                                salesForOnePeoples.Add(new PopulationRegionModel { Name = numTT[x].Name, Population = salesForOnePeople });
                            }
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
    }
}
