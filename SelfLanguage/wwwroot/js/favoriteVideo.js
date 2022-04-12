﻿/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

document.getElementById("star").addEventListener("click", postFavoriteVideo);

function postFavoriteVideo(json) {
    $.ajax({
        url: "https://localhost:44300/favoritevideo/post",
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(json)
    });
}