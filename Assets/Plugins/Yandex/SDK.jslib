mergeInto(LibraryManager.library, {
  ShowAd : function(value) {
    ysdk.adv.showRewardedVideo({
      callbacks: {
          onOpen: () => {
            console.log('Video ad open.');
          },
          onRewarded: () => {
            console.log('Rewarded!');
            myGameInstance.SendMessage("Coin","AddCoins",value);
          },
          onClose: () => {
            console.log('Video ad closed.');
          },
          onError: (e) => {
            console.log('Error while open video ad:', e);
          }
      }
    })
  },
  CheckCoins : function(value){
    console.log(value);
  },

});