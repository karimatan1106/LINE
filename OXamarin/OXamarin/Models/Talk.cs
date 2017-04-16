using System.Collections.ObjectModel;
using System.Collections.Generic;
using Prism.Mvvm;

namespace OXamarin.Models
{
    internal class Talk : BindableBase
    {
        #region プロパティ
        
        internal ObservableCollection<TalkDisplayInfo> TalkList = new ObservableCollection<TalkDisplayInfo>();

        #endregion

        #region フィールド

        private readonly List<string> _images;
        private readonly List<string> _times;
        private readonly List<string> _names;
        private readonly List<string> _contents;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// トーク画面に表示したい情報を設定
        /// 本来ならDB等から情報を取得
        /// </summary>
        public Talk()
        {
            _images = new List<string>
            {
                "OguriShun.png",
                "NinomiyaKazuya.png",
                "YamasakiKento.png",
                "TamakiHiroshi.png",
                "SakaiMasato.png",
                "SugataMasaki.png",
                "YamadaTakayuki.png",
                "YamashitaTomohisa.png",
                "MatsuzakaTori.png",
                "FukuyamaMasaharu.png",
            };
            _times = new List<string>
            {
                "0:00",
                "23:59",
                "23:30",
                "23:30",
                "23:30",
                "23:30",
                "23:30",
                "23:30",
                "23:30",
                "23:30",
            };
            _names = new List<string>
            {
                "小栗 旬",
                "二宮 和也",
                "山﨑 賢人",
                "玉木 宏",
                "堺 雅人",
                "菅田 将暉",
                "山田 孝之",
                "山下 智久",
                "松坂 桃李",
                "福山 雅治",
            };
            _contents = new List<string>
            {
                "昨日はありがとう。またごはんいこ",
                "起きてる？",
                "おーい",
                "今度いつ会える？",
                "倍返しだ",
                "別に",
                "ドラクエしようぜ",
                "ハレルヤチャンス",
                "俺の心臓の音を聞いてみな。YOSHIKIのドラムみたいだろ?",
                "家族になろうよ",
            };
        }

        #endregion

        #region メソッド

        /// <summary>
        /// トーク一覧に表示する情報を作成
        /// TalkListにAddしてViewModelへプロパティが追加された事を通知する
        /// </summary>
        internal void CreateList()
        {
            for (var i = 0; i < _times.Count; ++i)
            {
                var talkDisplayInfo = new TalkDisplayInfo
                {
                    TalkImage = _images[i],
                    TalkTime = _times[i],
                    TalkName = _names[i],
                    TalkContent = _contents[i],
                };
                TalkList.Add(talkDisplayInfo);
            }
        }

        #endregion
    }
}
