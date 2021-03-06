# How to implement a custom Sort By Summary feature


<p>The <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldBase_SortBySummaryInfotopic">PivotGridFieldBase.SortBySummaryInfo</a> property allows sorting data by displayed cell values and by using a custom summary algorithm. In the first case, it is necessary to specify the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldSortBySummaryInfo_Fieldtopic">PivotGridFieldSortBySummaryInfo.Field</a> property to sort data by fields summary values. In the second case, it is necessary to use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldSortBySummaryInfo_FieldNametopic">PivotGridFieldSortBySummaryInfo.FieldName</a> property to select a data source field that should be used to calculate summaries. In the latter case, you can select a summary type via the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldSortBySummaryInfo_SummaryTypetopic">PivotGridFieldSortBySummaryInfo.SummaryType</a> property. <br />
Built-in popup menu allow applying the Sort By Summary  feature by using the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldSortBySummaryInfo_Fieldtopic">PivotGridFieldSortBySummaryInfo.Field</a> property. This example demonstrates how to customize such a menu to provide the Sort By Summary feature using the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraPivotGridPivotGridFieldSortBySummaryInfo_FieldNametopic">PivotGridFieldSortBySummaryInfo.FieldName</a> property.</p>

<br/>


