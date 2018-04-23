<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>

    <script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")" type="text/javascript"></script>
    <script src="~/Scripts/jquery.validate.min.js"></script>
    <script src="~/Scripts/jquery.validate.unobtrusive.min.js"></script>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, 
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView}
    )
    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}, 
    New Script With {.ExtensionSuite = ExtensionSuite.GridView}, 
    New Script With {.ExtensionSuite = ExtensionSuite.Editors}
    )
</head>

<body>
    @RenderBody()
</body>
</html>
