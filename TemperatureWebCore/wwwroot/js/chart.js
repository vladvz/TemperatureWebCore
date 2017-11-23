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
        "categoryField": "date",
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
        ],
        "dataProvider": [
            {
                "date": "2014-03-01T07:57:02",
                "temperature": "22.1"
            },
            {
                "date": "2014-03-01T07:58:03",
                "temperature": "23.5"
            },
            {
                "date": "2014-03-01T07:59:04",
                "temperature": "26.1"
            },
            {
                "date": "2014-03-01T08:00:05",
                "temperature": "28.4"
            },
            {
                "date": "2014-03-01T08:01:06",
                "temperature": "27.3"
            },
            {
                "date": "2014-03-01T08:02:07",
                "temperature": "26.9"
            },
            {
                "date": "2014-03-01T08:03:08",
                "temperature": "25.8"
            }
        ]
    }
);

chart.addListener("clickGraphItem", function (event) {
    var time = event.item.dataContext.time;

    if (event.item.dataContext.time != undefined) {
        var stringDate = moment(time).format("MMM DD, YYYY");
        console.log(stringDate);

        detailChart.titles[0].text = stringDate;
        console.log(detailChart.titles[0].text);

        detailChart.validateData();
    }
});
