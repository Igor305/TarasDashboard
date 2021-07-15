import { Component, OnInit } from '@angular/core';
import { DiagramModel } from '../models/diagram.model';
import { SaleResponseModel } from '../models/response/sale.response.model';
import { SaleHistoryModel } from '../models/sale.history.model';
import { SaleOracleModel } from '../models/sale.oracle.model';
import { SaleRegionsModel } from '../models/sale.regions.model';
import { SaleStatisticModel } from '../models/sale.statistic.model';
import { SaleService } from '../services/sale.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})

export class HomeComponent implements OnInit {

  check: number;

  responseModel: SaleResponseModel;
  saleOracle: SaleOracleModel;
  percentOnlineStockLast: number;
  dateTime: string;

  saleStatisticModels: SaleStatisticModel[];

  displayedColumnsStatistic: string[] = ['dateOfString', 'tSumCC_wt', 'avgCheck', 'rec', 'margin', 'turnover'];

  saleRegionsModels: SaleRegionsModel[];

  displayedColumnsRegions: string [] = ['name', 'population', 'numberTT', 'populationForOneTT', 'salesForOnePeople'];

  lastLines: SaleRegionsModel;

  saleHistoryModels: SaleHistoryModel[];

  displayedColumnsHistory: string [] = ['dates', 'stocksQty', 'chainPlanDay', 'chainFactDay', 'executionPlanDayPercent', 'executionPlanDayUah'];

  diagramModels : DiagramModel[];

  single = [
    {
      "name": "Germany",
      "value": 8940000
    },
  ];

  view: any[] = [];

  // options
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = false;
  showXAxisLabel = false;
  xAxisLabel = 'Dates';
  showYAxisLabel = false;
  yAxisLabel = 'Sales';

  colorScheme = {
    domain: ['#5089d4']
  };

  constructor(private saleService: SaleService){}

  async ngOnInit(){

    this.check = 4;

    //setInterval(()=> this.getSale(),10000);
    setInterval(()=> this.getCheck(),200000);

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
  }

  public async getExcel(){
    
    let saleRegionsModels = this.saleRegionsModels;
    saleRegionsModels.push(this.lastLines);

    this.saleService.generateExel(saleRegionsModels);
  }
}