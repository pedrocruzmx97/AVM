<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pruevas.aspx.cs" Inherits="MVPG52.Pruevas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />



    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet">
    <!--Import Google Icon Font-->
    <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <!--Import materialize.css-->
    <link href="Content/materialize.min.css" rel="stylesheet" />
</head>

<body>

    <form id="form1" runat="server">

        <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
        <script type="text/javascript" src="js/materialize.min.js"></script>

        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="d" GroupName="radio" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="" GroupName="radio" />

            <p>
                <input class="with-gap" name="group3" type="radio" id="test5" checked />
                <label for="test5">Red</label>
            </p>

        </div>
      
          <div class="row">
    <div class="col s12">
      <div class="row">
        <div class="input-field col s12">
          <i class="material-icons prefix">textsms</i>

            <asp:TextBox ID="TextBox1" runat="server" CssClass="autocomplete" ></asp:TextBox>
          <label for="autocomplete-input">Autocomplete</label>
        </div>
      </div>
    </div>
  </div>

    </form>

     <script type="text/javascript">
       


         $('TextBox1.autocomplete').autocomplete({
            data: {
                "Apple": null,
                "Microsoft": null,
                "Google": 'http://placehold.it/250x250'
            },
            limit: 20, // The max amount of results that can be shown at once. Default: Infinity.
            onAutocomplete: function (val) {
                // Callback function when value is autcompleted.
            },
            minLength: 1, // The minimum length of the input for the autocomplete to start. Default: 1.
        });
    </script>
</body>

</html>
