import { SaleOracleModel } from "../sale.oracle.model";
import { SaleStatisticModel } from "../sale.statistic.model";
import { SaleRegionsModel } from "../sale.regions.model";
import { SaleHistoryModel } from "../sale.history.model";
import { DiagramModel } from "../diagram.model";
import { PlanSaleStockOnDateModel } from "../plan.sale.stock.on.date.model";

export interface SaleResponseModel{
    saleOracleModel?: SaleOracleModel;
    saleStatisticModels?: SaleStatisticModel[];
    saleRegionsModels?: SaleRegionsModel[];
    lastLines?: SaleRegionsModel;
    executionPlanDate_HistoryModels?: SaleHistoryModel[];
    diagramModels?: DiagramModel[];
    planSaleStockOnDateModels?: PlanSaleStockOnDateModel[];
    date?: string;
    time?: string;
    status?: boolean;
    message?: string;
}