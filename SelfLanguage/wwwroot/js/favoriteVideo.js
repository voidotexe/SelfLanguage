'use strict';

/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

let star = document.getElementById("star");

star.addEventListener("click", () => {
  $.ajax({
    url: "https://localhost:5001/favoritevideo/post",
    type: "POST",
    contentType: "application/json",
    data: JSON.stringify(favoriteVideoJson)
  });
});