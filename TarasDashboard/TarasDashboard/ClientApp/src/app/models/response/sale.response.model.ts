import { SaleOracleModel } from "../sale.oracle.model";
import { SaleStatisticModel } from "../sale.statistic.model";
import { SaleRegionsModel } from "../sale.regions.model";

export interface SaleResponseModel{
    saleOracleModel?: SaleOracleModel;
    saleStatisticModels?: SaleStatisticModel[];
    saleRegionsModels?: SaleRegionsModel[];
    lastLines?: SaleRegionsModel;
    date?: string;
    time?: string;
    status?: boolean;
    message?: string;
}