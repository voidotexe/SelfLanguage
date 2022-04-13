/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

document.getElementById("star").addEventListener("click", postFavoriteVideo(favoriteVideoJson));

function postFavoriteVideo(favoriteVideoJson) {
    $.ajax({
        url: "https://localhost:44300/favoritevideo/post",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(favoriteVideoJson)
    });
}