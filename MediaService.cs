using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HNDunit20
{
    class MediaService : ServiceInterface
    {
        public double SongPrice
        {
            get { return 2.5; }
        }

        public IList<string> Songs
        {
            get
            {
                return new List<string>
                {
                    "Song 1",
                    "Song 2",
                    "Song 3"
                };
            }
        }

        public void ListAll()
        {
            foreach (var song in Songs)
            {
                // logic to append each song to an output window, similar to the previous jukebox functionality
            }
        }

        /// <summary>
        /// This will take the current media account which will have access to a bank account.
        /// The functionality to check if the user has enough money in their account should be handled by the
        /// the media service as they would be the one handling the transaction but the dup check could go within
        /// the media account
        /// </summary>
        /// <param name="account">Media account from the current app context</param>
        /// <param name="songToPurchase">Name of the song passed from the selection</param>
        /// <returns></returns>
        public string Purchase(MediaAccount account, string songToPurchase)
        {
            if (account.UserSongs.Contains(songToPurchase)) return "Song already in users collection";
            if (!account.bankAccount.withdraw(account.mediaService.SongPrice)) return "Not enough money in account";
            account.UserSongs.AddLast("songToPurchase");
            return $"{songToPurchase} added to collection";
        }
    }
}
