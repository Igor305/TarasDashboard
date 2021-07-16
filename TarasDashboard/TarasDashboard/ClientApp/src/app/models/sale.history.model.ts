import { DiagramModel } from "./diagram.model";

export interface SaleHistoryModel{
    dates?: Date;
    dateString?: string;
    chainPlanDay?: number;
    chainPlayDayString?: string;
    chainFactDay?: number;
    chainFactDayString?: string;
    stocksQty?: number;
    executionPlanDayUah?: number;
    executionPlanDayUahString?: string;
    executionPlanDayPercent?: number;
    chainPlanToDate?: number;
    chainFactToDate?: number;
    executionPlanToDateUah?: number;
    executionPlanToDatePercent?: number;
    diagramModels?: DiagramModel;
}