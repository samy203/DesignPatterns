using Adapter;

var xmlConverter = new XMLConverter();
var adapter = new XMLToJsonAdapter(xmlConverter);
adapter.Convert();