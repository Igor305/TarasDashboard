import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SaleResponseModel } from '../models/response/sale.response.model';

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
}
