/*
 This file is auto-generated, do not edit
*/


using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Recombee.ApiClient.ApiRequests;
using Recombee.ApiClient.Bindings;

namespace Recombee.ApiClient.Tests
{
    public class ListUserBookmarksUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListUserBookmarks()
        {
            ListUserBookmarks req;
            Request req2;
            IEnumerable<Bookmark> resp;
            // it 'lists user interactions'
            req = new ListUserBookmarks("user");
            System.Threading.Thread.Sleep(10000);
            resp = client.Send(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListUserBookmarksAsync()
        {
            ListUserBookmarks req;
            Request req2;
            IEnumerable<Bookmark> resp;
            // it 'lists user interactions'
            req = new ListUserBookmarks("user");
            System.Threading.Thread.Sleep(10000);
            resp = await client.SendAsync(req);
            Assert.Equal(1, resp.Count());
            Assert.Equal ("item",resp.ElementAt(0).ItemId);
            Assert.Equal ("user",resp.ElementAt(0).UserId);
        }
    }
}
