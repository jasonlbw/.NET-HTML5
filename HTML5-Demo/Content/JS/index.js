window.onload = function () {
    search();
    secondKill();
};

var search = function () {
    var bannerDom = document.getElementsByClassName('jd_banner')[0];
    var height = bannerDom.offsetHeight;
    var headerDom = document.getElementsByClassName('jd_header_box')[0];

    window.onscroll = function () {
        var top = document.body.scrollTop;
        var opt = 0;

        if (top <= height) {
            opt = top / height * 0.85;
        } else {
            opt = 0.85;
        }
        headerDom.style.background = "rgba(201,21,35," + opt + ")";
    }
};

/*倒计时*/
function secondKill() {
    var parentTimeBox = document.getElementsByClassName("sk_time")[0];
    var spans = parentTimeBox.getElementsByTagName("span");

    var time = 8 * 60 * 60;
    var timer;

    timer = setInterval(function () {
        time--;
        if (time < 0) {
            clearInterval(timer);
            return false;
        }
        var h = Math.floor(time / (60 * 60));
        var m = Math.floor(time % (60 * 60) / 60);
        var s = time % 60;

        spans[0].innerHTML = h > 10 ? Math.floor(h / 10) : 0;
        spans[1].innerHTML = h % 10;

        spans[3].innerHTML = m > 10 ? Math.floor(m / 10) : 0;
        spans[4].innerHTML = m % 10;

        spans[6].innerHTML = s > 10 ? Math.floor(s / 10) : 0;
        spans[7].innerHTML = s % 10;
    }, 1000);
}