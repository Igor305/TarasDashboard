import { Component, OnInit, ViewChild} from '@angular/core';
import { DiagramModel } from '../models/diagram.model';
import { SaleResponseModel } from '../models/response/sale.response.model';
import { SaleHistoryModel } from '../models/sale.history.model';
import { SaleOracleModel } from '../models/sale.oracle.model';
import { SaleRegionsModel } from '../models/sale.regions.model';
import { SaleStatisticModel } from '../models/sale.statistic.model';
import { SaleService } from '../services/sale.service';

import {
  ChartComponent,
  ApexAxisChartSeries,
  ApexChart,
  ApexFill,
  ApexYAxis,
  ApexTooltip,
  ApexTitleSubtitle,
  ApexXAxis
} from "ng-apexcharts";
import { ConditionalExpr } from '@angular/compiler';
import { PlanSaleStockOnDateModel } from '../models/plan.sale.stock.on.date.model';

export type ChartOptions = {
  series: ApexAxisChartSeries;
  chart: ApexChart;
  xaxis: ApexXAxis;
  yaxis: ApexYAxis | ApexYAxis[];
  title: ApexTitleSubtitle;
  labels: string[];
  stroke: any; // ApexStroke;
  dataLabels: any; // ApexDataLabels;
  fill: ApexFill;
  tooltip: ApexTooltip;
};

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})

export class HomeComponent implements OnInit {

  @ViewChild("chart") chart: ChartComponent;
  public chartOptions: Partial<ChartOptions>;

  check: number;

  executionPlanToDatePercent : number;
  executionPlanToDatePercentLast : number;
  executionPlanToDatePercentString : string;
  chainFactToDate : string;
  chainPlanToDate : string;
  
  responseModel: SaleResponseModel;
  saleOracle: SaleOracleModel;
  percentOnlineStockLast: number;
  dateTime: string;

  saleStatisticModels: SaleStatisticModel[];

  displayedColumnsStatistic: string[] = ['dateOfString', 'tsumCc_Wt', 'avgCheck', 'rec', 'margin', 'turnover', 'LFL'];

  saleRegionsModels: SaleRegionsModel[];

  displayedColumnsRegions: string [] = ['name', 'population', 'numberTT', 'populationForOneTT', 'salesForOnePeople'];

  lastLines: SaleRegionsModel;

  saleHistoryModels: SaleHistoryModel[];

  displayedColumnsHistory: string [] = ['dates', 'stocksQty', 'chainPlanDay', 'chainFactDay', 'executionPlanDayPercent', 'executionPlanDayUah'];

  diagramModels : DiagramModel[];

  planSaleStockOnDateModels : PlanSaleStockOnDateModel[];

  plans = []
  facts = []
  dates = []

  constructor(private saleService: SaleService){
  }

  async ngOnInit(){

    this.check = 4;

    setInterval(()=> this.getSale(),30000);
    setInterval(()=> this.getCheck(),30000);

    await this.getSale();
  }

  public async getCheck(){

    switch(this.check){
      case 1 : this.check = 2;break;
      case 2 : this.check = 3;break;
      case 3 : this.check = 4;break;
      case 4 : this.check = 1;break;
    }
  }

  public async getSale(){

    this.responseModel = await this.saleService.getSale();

    this.saleOracle = this.responseModel.saleOracleModel;
    this.percentOnlineStockLast = 100 - this.saleOracle.percentOnlineStock;

    this.saleStatisticModels = this.responseModel.saleStatisticModels;
    this.saleRegionsModels = this.responseModel.saleRegionsModels;
    this.dateTime = this.responseModel.date + " " + this.responseModel.time;

    this.lastLines = this.responseModel.lastLines;

    this.saleHistoryModels = this.responseModel.executionPlanDate_HistoryModels;
    this.diagramModels = this.responseModel.diagramModels;
    this.planSaleStockOnDateModels = this.responseModel.planSaleStockOnDateModels;

    let date = new Date(Date.now()-86400000) 

    for (let saleStatistic of this.saleStatisticModels){
      saleStatistic.lflString = saleStatistic.lfl.toFixed(2);
    }

    this.plans = [];
    this.facts = [];
    this.dates = [];

    for(let saleHistoryModel of this.saleHistoryModels ){

      this.plans.push(saleHistoryModel.chainPlanDay);
      this.facts.push(saleHistoryModel.chainFactDay);  

      let dateString = "";  

      if (date.getDate() < 10){
        dateString = saleHistoryModel.dateString.split('.')[0].slice(1);       
      }

      if (date.getDate() >= 10){
        dateString = saleHistoryModel.dateString.split('.')[0];
      }

      if (date.getUTCDate().toString() == dateString ){
    
        this.executionPlanToDatePercentString = Math.trunc(saleHistoryModel.executionPlanToDatePercent).toFixed(0);
        this.executionPlanToDatePercent = saleHistoryModel.executionPlanToDatePercent;      
        this.executionPlanToDatePercentLast = 100 - saleHistoryModel.executionPlanToDatePercent;
        this.chainFactToDate = (saleHistoryModel.chainFactToDate / 1000000).toFixed(2);
        this.chainPlanToDate = (saleHistoryModel.chainPlanToDate / 1000000).toFixed(2);
      }
    }

    this.planSaleStockOnDateModels.forEach(planSaleStockOnDateModel => {
      this.plans.push(planSaleStockOnDateModel.planSum);     
    });

    this.saleHistoryModels.reverse();

    for(let diagramModel of this.diagramModels ){
        this.dates.push(diagramModel.name);      
    }

    this.chartOptions = {
      series: [
        {
          name: "Факт",
          type: "column",
          data: this.facts
        },
        {
          name: "План",
          type: "line",
          data: this.plans
        }
      ],
      chart: {
        height: 650,
        type: "line",
        fontFamily:'Roboto,"Helvetica Neue", sans-serif',
      },
      stroke: {
        width: [0, 4]
      },
      title: {},
      dataLabels: {
        enabled: true,
        enabledOnSeries: [1]
      },
      labels:this.dates,
      xaxis: {
        type: "datetime",
        tickPlacement: 'between',
        labels: {
          datetimeUTC: false,
          datetimeFormatter: {
            year: 'yyyy',
            month: "dd.MM",
            day: 'dd.MM',
            hour: 'HH:mm',
          },
          style:{
            fontSize:'15px'
          },
        },
      },
      yaxis: {
        labels: {
          style:{
            fontSize:'15px'
          },
        },
      },
      tooltip: {
        enabled: true,
        enabledOnSeries: undefined,
        shared: true,
        followCursor: false,
        intersect: false,
        inverseOrder: false,
        custom: undefined,
        fillSeriesColor: false,
        style: {
          fontSize: '12px',
          fontFamily: undefined
        },
        onDatasetHover: {
            highlightDataSeries: false,
        },
        x: {
            show: false,
            format: 'dd MMM',
            formatter: undefined,
        },
        y: {
            formatter: undefined,
            title: {
                formatter: (seriesName) => seriesName,
            },
        },
        z: {
            formatter: undefined,
            title: 'Size: '
        },
        marker: {
            show: true,
        },
        fixed: {
            enabled: false,
            position: 'topRight',
            offsetX: 0,
            offsetY: 0,
        },
      }
    }; 
  }

  public async getExcel(){
    
    let saleRegionsModels = this.saleRegionsModels;
    saleRegionsModels.push(this.lastLines);

    this.saleService.generateExel(saleRegionsModels);
  }
}