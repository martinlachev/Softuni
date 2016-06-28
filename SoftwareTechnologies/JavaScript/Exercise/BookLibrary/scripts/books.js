/**
 * Created by MartinLachev on 6/27/2016.
 */
const kinveyBaseUrl = "https://baas.kinvey.com";
const kinveyAppKey = "kid_Sk0QS0AS";
const kinveyAppSecret = "24ef05d464bd4150bb37f853988d3d99";

function showView(viewName) {

    $('main > section').hide();
    $('#'+ viewName).show();

}

function showHideMenuLinks() {
    $("#linkHome").show();
    if (sessionStorage.getItem('authToken')==null){
        $('#linkLogin').show();
        $('#linkRegister').show();
        $("#linkListBooks").hide();
        $('#linkCreateBook').hide();
        $('#linkLogout').hide();
    }
    else{
        $('#linkLogin').hide()
        $('#linkRegister').hide();
        $("#linkListBooks").show();
        $('#linkCreateBook').show();
        $('#linkLogout').show();
    }
}

$(function() {
    showHideMenuLinks();
    showView('viewHome');

    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListBooks').click(listBooks);
    $('#linkCreateBook').click(showCreateBookView);
    $('#linkLogout').click(logout);
    $('#linkHome').click(showHomeView);

    $('#formLogin').submit(function (e) {
        e.preventDefault();
        login();
    });
    $('#formRegister').submit(function (e) {
        e.preventDefault();
        register();
    });
    $('#formCreateBook').submit(function (e) {
        e.preventDefault();
        createBook();
    });

    $(document).on({
        ajaxStart: function(){$("#loadingBox").show()},
        ajaxStop: function () {$("#loadingBox").hide()}

    });
})

function showHomeView() {
    showView('viewHome');
}

function showLoginView() {
    showView('viewLogin')
}

function login() {
    const kinveyLoginUrl = kinveyBaseUrl +"user/"+kinveyAppKey+"/login";
    const kinveyAuthHeaders ={
        'Authorization': "Basic " + btoa(kinveyAppKey+ ":"+ kinveyAppSecret),
    };
    let userData = {
        username:$('#loginUser').val(),
        password:$('#loginPass').val()

    };
    $.ajax({
        method:"POST",
        url:kinveyLoginUrl,
        headers:kinveyAuthHeaders,
        data:userData,
        success: loginSuccess,
        error:handleAjaxError
    });

    function loginSuccess(responce) {
        let userAuth = responce._kmd.authtoken;
        sessionStorage.setItem('authToken',userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('Login successful.');

    }
    

}

function handleAjaxError(responce) {
    let erroMsg = JSON.stringify(responce);
    if(responce.readyState == 0){
        erroMsg ="Cannot connect due to network error.";

    }
    if (responce.responseJSON && responce.responseJSON.description){
        erroMsg = responce.responseJSON.description;
    }
    showError(erroMsg);
}

function showRegisterView() {

    showView('viewRegister')

}

function register() {
    const kinveyRegisterUrl = kinveyBaseUrl +"user/"+kinveyAppKey+"/login";
    const kinveyAuthHeaders ={
        'Authorization': "Basic " + btoa(kinveyAppKey+ ":"+ kinveyAppSecret),
    };
    let userData = {
        username:$('#registerUser').val(),
        password:$('#registerPass').val()

    };
    $.ajax({
        method:"POST",
        url:kinveyRegisterUrl,
        headers:kinveyAuthHeaders,
        data:userData,
        success: registerSuccess,
        error:handleAjaxError
    });

    function registerSuccess(responce) {
        let userAuth = responce._kmd.authtoken;
        sessionStorage.setItem('authToken',userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('User registration successful.');

    }
}

function listBooks() {
    $('#books').empty();
    showView('viewBooks');

    const kinveyBooksUrl = kinveyBaseUrl+"appdata/"+ kinveyAppKey+"/books";
    const kinveyAuthHeaders = {
        'Authoriztion' :"Kinvey" + sessionStorage.getItem('authToken'),
    };
    $.ajax({
        method:"GET",
        url:kinveyBooksUrl,
        headers:kinveyAuthHeaders,
        success:loadBooksSuccess,
        error: handleAjaxError
    });

    function loadBooksSuccess(books) {
        showInfo('Books loaded.');
        if(books.length==0){
            $('#books').text('No books in the library.');
        }else{
            let booksTable = $('<table>')
                .append($('<tr>').append(
                    '<th>Title</th>th>',
                    '<th>Author</th>th>',
                    '<th>Description</th>th>'

                ));

            for(let book of books){
                booksTable.append($('<tr>')).append(
                    $('<td>').text(book.title),
                    $('<td>').text(book.author),
                    $('<td>').text(book.description))
                ;
            }


            $('#books').append(booksTable);


        }
    }
}

function showCreateBookView() {
    showView('viewCreateBook');
}
function createBook() {
    const kinveyBooksUrl = kinveyBaseUrl+"appdata/"+ kinveyAppKey+"/books";
    const kinveyAuthHeaders = {
        'Authoriztion': "Kinvey" + sessionStorage.getItem('authToken'),
    };
    let bookData ={
        title:$('#bookTitle').val(),
        author:$('#bookAuthor').val(),
        description:$('#bookDescription').val()
    };

    $.ajax({
        method:"POST",
        url:kinveyBooksUrl,
        headers:kinveyAuthHeaders,
        success:createBookSuccess,
        error: handleAjaxError
    });
    
    function createBookSuccess() {
        listBooks();
        showInfo('Book created.');
    }
    
    
}

function logout() {
    sessionStorage.clear();
    showHideMenuLinks();
    showView('viewHome');
}