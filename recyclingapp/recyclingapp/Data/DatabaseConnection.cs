using recyclingapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace recyclingapp.Data
{
    public class DatabaseConnection
    {
        readonly SQLiteAsyncConnection _database;

        public DatabaseConnection(string dbPath)
        {
            
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Models.campaign>().Wait();
            _database.CreateTableAsync<Discuss>().Wait();
            _database.CreateTableAsync<Recyclingcentre>().Wait();
            _database.CreateTableAsync<Reply>().Wait();
            _database.CreateTableAsync<Models.UserRegistration>().Wait();
           
        }

        // Campaign table logic
        public Task<List<Models.campaign>> GetCampaignAsync()
        {
            return _database.Table<Models.campaign>().ToListAsync();
        }

        public Task<Models.campaign> GetSingleCampaignAsync(int id)
        {
            return _database.Table<Models.campaign>()
                            .Where(i => i.CampID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCampaignAsync(Models.campaign campaign)
        {
            if (campaign.CampID != 0)
            {
                return _database.UpdateAsync(campaign);
            }
            else
            {
                return _database.InsertAsync(campaign);
            }
        }

        public Task<int> DeleteCampaignAsync(Models.campaign campaign)
        {
            return _database.DeleteAsync(campaign);
        }

        // discuss table logic
        public Task<List<Discuss>> GetDiscussAsync()
        {
            return _database.Table<Discuss>().ToListAsync();
        }

        public Task<Discuss> GetSingleDiscussAsync(int id)
        {
            return _database.Table<Discuss>()
                            .Where(i => i.DissID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveDiscussAsync(Discuss  discuss)
        {
            if (discuss.DissID != 0)
            {
                return _database.UpdateAsync(discuss);
            }
            else
            {
                return _database.InsertAsync(discuss);
            }
        }

        public Task<int> DeleteDiscussAsync(Discuss discuss)
        {
            return _database.DeleteAsync(discuss);
        }
        // for Recycling 
        public Task<List<Recyclingcentre>> GetRecylingAsync()
        {
            return _database.Table<Recyclingcentre>().ToListAsync();
        }

        public Task<Recyclingcentre> GetSingleRecyclingAsync(int id)
        {
            return _database.Table<Recyclingcentre>()
                            .Where(i => i.RcID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveRecyclingAsync(Recyclingcentre recycling)
        {
            if (recycling.RcID != 0)
            {
                return _database.UpdateAsync(recycling);
            }
            else
            {
                return _database.InsertAsync(recycling);
            }
        }

        public Task<int> DeleteRecyclingAsync(Recyclingcentre recycling)
        {
            return _database.DeleteAsync(recycling);
        }
        // for reply
        public Task<List<Reply>> GetReplyAsync()
        {
            return _database.Table<Reply>().ToListAsync();
        }

        public Task<Reply> GetSingleReplyAsync(int id)
        {
            return _database.Table<Reply>()
                            .Where(i => i.ReplyID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveReplyAsync(Reply reply)
        {
            if (reply.ReplyID != 0)
            {
                return _database.UpdateAsync(reply);
            }
            else
            {
                return _database.InsertAsync(reply);
            }
        }

        public Task<int> DeleteReplyAsync(Reply reply)
        {
            return _database.DeleteAsync(reply);
        }

        // for user registration
        public Task<List<Models.UserRegistration>> GetUserRegistrationAsync()
        {
            return _database.Table<Models.UserRegistration>().ToListAsync();
        }

        public Task<Models.UserRegistration> GetSingleUserRegistrationAsync(int id)
        {
            return _database.Table<Models.UserRegistration>()
                            .Where(i => i.UserID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<Models.UserRegistration> LoginUserAsync(string username, string password)
        {
            return _database.Table<Models.UserRegistration>()
                .Where(i => i.Username == username && i.Password == password)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserRegistrationAsync(Models.UserRegistration user)
        {
            if (user.UserID != 0)
            {
                return _database.UpdateAsync(user);
            }
            else
            {
                return _database.InsertAsync(user);
            }
        }

        public Task<int> DeleteUserRegistrationAsync(Models.UserRegistration user)
        {
            return _database.DeleteAsync(user);
        }

    }
}
