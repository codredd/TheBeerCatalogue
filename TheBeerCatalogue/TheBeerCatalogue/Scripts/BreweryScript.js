$(document).ready(function () {
    $('#myGrid').DataTable({
        "ajax": {
            "url": "/Brewery/GetBrewery/",
            "dataSrc": ""
        },
        "columns": [
            { "data": "id" },
            { "data": "name" },
            { "data": "website" },
            { "data": "description" }]
    });
});