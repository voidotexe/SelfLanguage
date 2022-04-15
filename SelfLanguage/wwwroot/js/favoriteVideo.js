/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

var star = document.getElementById("star");

function handleFavoriteVideo(favoriteVideoJson) {
  $.ajax({
    url: "https://localhost:5001/favoritevideo/post",
    type: "POST",
    contentType: "application/json",
    data: JSON.stringify(favoriteVideoJson)
  });
}

star.addEventListener("click", function() {
  handleFavoriteVideo(favoriteVideoJson);
});