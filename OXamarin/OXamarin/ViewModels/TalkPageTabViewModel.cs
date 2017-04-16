using OXamarin.Models;
using Reactive.Bindings;

namespace OXamarin.ViewModels
{
    internal class TalkPageTabViewModel
    {
        #region プロパティ

        //トーク一覧画面に表示する情報を保持
        public ReadOnlyReactiveCollection<TalkDisplayInfo> TalkList { get; set; }

        #endregion

        #region フィールド

        private readonly Talk _talk = new Talk();

        #endregion

        #region コンストラクタ

        public TalkPageTabViewModel()
        {
            //トーク一覧に表示する情報を更新
            _talk.CreateList();

            //TalkクラスのTalkListプロパティの変更通知を受け取るようにする
            TalkList = _talk.TalkList.ToReadOnlyReactiveCollection();
        }

        #endregion
    }
}
