function EditPlayer(sender) {
    if (sender.text.toLocaleLowerCase() == "edit") {
        $(sender).parents('tr').find("td").each(function (ElementIndex) {
            if (this.children.length == 0 && ElementIndex < 3) {
                if (isNaN($(this).html()) == false && $(this).html() != "")
                    $(this).replaceWith("<td><input class='form-control' onchange='PlayerEdited(this)' type='number' value='" + $(this).html() + "'/></td>")
                else
                    $(this).replaceWith("<td><input class='form-control' onchange='PlayerEdited(this)' type='text' value='" + $(this).html() + "'/></td>")
            }
        });
        $(sender).html("Save");
    } else if (sender.text.toLocaleLowerCase() == "save") {
        $(sender).parents('tr').find("input").each(function (ThisElement) {
            $(this).replaceWith($(this).val());
        });
        $(sender).html("Edit");
    }
}

function AddPlayer() {
    $("tbody").append("<tr class='EditedPlayer'><td></td><td>1</td><td>0</td><td><div class='Losses'></div></td><td><div class='Ratio'></div></td><td><a class='btn btn-xs btn-primary EditButton' style='text-align:center;' onclick='EditPlayer(this)'>Edit</a></td></tr>");
}

function PlayerEdited(sender) {
    $(sender).parents('tr').addClass('EditedPlayer')
}

function SavePlayers() {
    var delimitedString = "";
    debugger;

    //This selector is for file use
    //$(".EditedPlayer.PlayerList tr:not(:first-child)")
    
    $(".PlayerList .EditedPlayer").each(function (index, element) {
        delimitedString += element.children[0].innerText + "|" + element.children[1].innerText + "|" + element.children[2].innerText + "|" + element.children[3].innerText + ";";
    });
    $("#hfPlayerStats").val(delimitedString);
}