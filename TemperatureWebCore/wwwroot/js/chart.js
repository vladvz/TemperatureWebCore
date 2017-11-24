var chart = AmCharts.makeChart("chartdiv",
    {
        "type": "serial",
        "categoryField": "time",
        "dataDateFormat": "YYYY-MM-DD",
        "precision": 1,
        "categoryAxis": {
            "parseDates": true
        },
        "chartCursor": {
            "enabled": true
        },
        "chartScrollbar": {
            "enabled": true
        },
        "trendLines": [],
        "graphs": [
            {
                "bullet": "round",
                "id": "AmGraph-1",
                "title": "Max",
                "valueField": "maxTemperature"
            },
            {
                "bullet": "round",
                "id": "AmGraph-2",
                "title": "Average",
                "valueField": "avgTemperature"
            },
            {
                "bullet": "round",
                "id": "AmGraph-3",
                "title": "Min",
                "valueField": "minTemperature"
            }
        ],
        "guides": [],
        "valueAxes": [
            {
                "id": "ValueAxis-1",
                "title": ""
            }
        ],
        "allLabels": [],
        "balloon": {},
        "legend": {
            "enabled": true,
            "useGraphSettings": true
        },
        "titles": [
            {
                "id": "Title-1",
                "size": 15,
                "text": "Daily temperatures"
            }
        ],
        "dataLoader": {
            "url": "/api/dailytemps"
        }
    }
);

var detailChart = AmCharts.makeChart("detailChartdiv",
    {
        "type": "serial",
        "categoryField": "time",
        "dataDateFormat": "YYYY-MM-DD HH:NN",
        "precision": 1,
        "processCount": 997,
        "processTimeout": 100,
        "categoryAxis": {
            "minPeriod": "mm",
            "parseDates": true
        },
        "chartCursor": {
            "enabled": true,
            "categoryBalloonDateFormat": "JJ:NN"
        },
        "chartScrollbar": {
            "enabled": true
        },
        "trendLines": [],
        "graphs": [
            {
                "bullet": "round",
                "id": "AmGraph-1",
                "title": "Temp",
                "valueField": "temperature"
            }
        ],
        "guides": [],
        "valueAxes": [
            {
                "id": "ValueAxis-1",
                "title": ""
            }
        ],
        "allLabels": [],
        "balloon": {},
        "legend": {
            "enabled": true,
            "useGraphSettings": true
        },
        "titles": [
            {
                "id": "Title-1",
                "size": 15,
                "text": "No selection"
            }
        ]
    }
);

chart.addListener("clickGraphItem", function (event) {
    var time = event.item.dataContext.time;

    if (event.item.dataContext.time != undefined) {
        var title = moment(time).format("MMM DD, YYYY");
        var stringDate = moment(time).format("YYYY-MM-DD");
        console.log(stringDate);

        detailChart.titles[0].text = title;
        console.log(detailChart.titles[0].text);

        detailChart.dataLoader.url = "/api/dailytemps/" + stringDate;
        detailChart.dataLoader.loadData();
        detailChart.validateData();
    }
});
