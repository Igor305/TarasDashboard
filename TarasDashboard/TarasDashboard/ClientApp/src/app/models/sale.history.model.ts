import { DiagramModel } from "./diagram.model";

export interface SaleHistoryModel{
    dates?: Date;
    dateString?: string;
    chainPlanDay?: number;
    chainFactDay?: number;
    stocksQty?: number;
    executionPlanDayUah?: number;
    executionPlanDayPercent?: number;
    chainPlanToDate?: number;
    chainFactToDate?: number;
    executionPlanToDateUah?: number;
    executionPlanToDatePercent?: number;
    diagramModels?: DiagramModel;
}