$('.actionLnkBttn').button();

$('.lnkBttn').click(function () {
    $.ajax({
        url: this.id,
        success: function (data) {
        },
        error: function (data) {
        }
    });
});

$(".actionLnkBttn").button();

$(document).ready(function () {
    $('.ModalDlg').on("click", function (event) { loadDialog(this, event); });   
});



function loadDialog(tag, event) {
    event.preventDefault();
    var $dialog = $('<div></div>');
    var $url = $(tag).attr('href');
    var $title = $(tag).attr("data_dialog_title");
    $dialog.empty();
    
    $dialog
        .load($url)
        .addClass("dialog")
        .attr("id", $(tag).attr("data-dialog-id"))
        .dialog({
            autoOpen:true,
            title: $title,
            close: function () { $(this).remove(); },
            modal: true,
            show: 'fade',
            hide: 'fade',
            width: 600,
            position: ['middle', 20]
        });
    $dialog.dialog("option", "buttons", {
        "Cancel": function () {
            $(this).dialog("close");
            $(this).empty();
        },
        "Submit": function () {
            var dlg = $(this);
            $.ajax({
                url: $url,
                type: 'POST',
                data: $("#target").serialize(),

                success: function (response) {
                    $(target).html(response);
                    dlg.dialog('close');
                    dlg.empty();
                    $("#result").hide().html('Record saved').fadeIn(300, function () {
                        var e = this;
                        setTimeout(function () { $(e).fadeOut(400); }, 2500);
                    });
                },
                error: function (xhr) {
                }
            });
        }
    });

    $dialog.open('open');
};
            
/*
$(document).ready(function () {
 //   zebraRows('tbody tr:odd td', 'odd');
    $("#datepicker").datepicker();
    var tabs = $("#tabs").tabs();

   $(".filter").keyup(function (event) {
       
        if (event.keyCode == 27 || $(this).val == '') {
            $(this).val = '';
            $("").removeClass('visible').show().addClass('visible');
        }
        else {
            filter('tbody tr', $(this).val());
        }

       //reapply zebra rows
        $('.visible td').removeClass('odd');
        zebraRows('.visible:even td', 'odd');
    });

   
});

function filter(selector, query) {
    query = $.trim(query);
    query = query.replace(/ /gi, '|');
    $(selector).each(function () {
        ($(this).text().search(new RegExp(query, "i")) < 0) ? $(this).hide().removeClass('visible') : $(this).show().addClass('visible');
    });
}




function loadDialog(tag, event, target) {
    alert("Test");
};


/*
function zebraRows(selector, className) {
    $(selector).removeClass(className)
							.addClass(className);
}

/*
$(function () {
  
});

/*
$(function () {

    var ajaxFormSubmit = function () {
        var $form = $(this);

        var options = {
            url: $form.attr("action"),
            type: $form.attr("method"),
            data: $form.serialize()
        };

        $.ajax(options).done(function (data) {
            var $target = $($form.attr("data-doris-target"));
            var $newHtml = $(data);
            $target.replaceWith($newHtml);
            $newHtml.effect("highlight");
        });

        return false;
    };

    var submitAutocompleteForm = function (event, ui) {

        var $input = $(this);
        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    };

    var createAutocomplete = function () {
        var $input = $(this);

        var options = {
            source: $input.attr("data-doris-autocomplete"),
            select: submitAutocompleteForm
        };

        $input.autocomplete(options);
    };

    var getPage = function () {
        var $a = $(this);

        var options = {
            url: $a.attr("href"),
            data: $("form").serialize(),
            type: "get"
        };

        $.ajax(options).done(function (data) {
            var target = $a.parents("div.pagedList").attr("data-doris-target");
            $(target).replaceWith(data);
        });
        return false;

    };

    $("form[data-doris-ajax='true']").submit(ajaxFormSubmit);
  //  $("input[data-doris-autocomplete]").each(createAutocomplete);

    $(".main-content").on("click", ".pagedList a", getPage);


});

*/