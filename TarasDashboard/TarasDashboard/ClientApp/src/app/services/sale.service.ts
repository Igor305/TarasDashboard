import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SaleResponseModel } from '../models/response/sale.response.model';
import { Workbook } from 'exceljs';
import * as fs from 'file-saver';
import { SaleRegionsModel } from '../models/sale.regions.model';

@Injectable({
  providedIn: 'root'
})
export class SaleService {

  constructor(private http: HttpClient) { }

  public async getSale(): Promise<SaleResponseModel>{
    const url: string = "/api/Statistics";
    const sale = await this.http.get<SaleResponseModel>(url).toPromise();
    return sale;
  }

  public async generateExel(saleRegionsModels : SaleRegionsModel[]){

  const title = 'Sales By Regions';
  const header = ["", "Pop", "NoS", "PpS", "Sa/P-30"]

  let data = [,];
  let d = [,];
  let max = 0;

  for (let sale of saleRegionsModels){

    d.push([
      sale.name, 
      sale.population, 
      sale.numberTT, 
      sale.populationForOneTT, 
      sale.salesForOnePeople
    ]);  

    if(sale.percentSalesForOnePeople == 100){
      max = sale.salesForOnePeople;
    }

  }

  console.log(data);

  let workbook = new Workbook();
  let worksheet = workbook.addWorksheet('Sales By Regions');

  let titleRow = worksheet.addRow([title]);
  titleRow.font = { name: 'Comic Sans MS', family: 4, size: 24, underline: 'double', bold: true };
  worksheet.addRow([]);

  let headerRow = worksheet.addRow(header);

    headerRow.eachCell((cell, number) => {
      cell.font = {
        bold: true,
      }
      cell.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
    });

    const dobCol = worksheet.getColumn('A');
    dobCol.width = 20;

    let x = 1;

    d.forEach(d => {
      let row = worksheet.addRow(d);

      let qty1 = row.getCell(1);
      let qty2 = row.getCell(2);
      let qty3 = row.getCell(3);
      let qty4 = row.getCell(4);
      let qty5 = row.getCell(5);
      qty1.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
      qty2.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
      qty3.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
      qty4.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
      qty5.border = { top: { style: 'thin' }, left: { style: 'thin' }, bottom: { style: 'thin' }, right: { style: 'thin' } }
      x++;
      
      let qty = row.getCell(5);
      let color = '000000';
      
      if (+qty.value * 100 /max <= 20 ) {
        color = 'E82A2D'
      }

      if (+qty.value * 100 /max <= 40 && +qty.value * 100 /max > 20) {
        color = 'F87173'
      }

      if (+qty.value * 100 /max <= 60 && +qty.value * 100 /max > 40) {
        color = '000000'
      }

      if (+qty.value * 100 /max <= 80 && +qty.value * 100 /max > 60) {
        color = '60C67B'
      }

      if (+qty.value * 100 /max <= 100 && +qty.value * 100 /max > 80) {
        color = '1C9A3D'
      }

      qty.fill = {
        type: 'pattern',
        pattern: 'solid',
        fgColor: { argb: 'FFFFFF' }
      }

      qty.font= {
        color : { argb: color }  
      }
    });

    worksheet.addRows(data);

    workbook.xlsx.writeBuffer().then((data) => {
      let blob = new Blob([data], { type: 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet' });
      fs.saveAs(blob, 'SaleByRegions.xlsx');
    });

  }
}