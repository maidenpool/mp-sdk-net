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
    public class ListItemRatingsBatchUnitTest: InteractionsUnitTest
    {

        [Fact]
        public  void TestListItemRatings()
                {
            Request[] requests = new Request[] {
                new ListItemRatings("item")
            };
        
            BatchResponse batchResponse = client.Send(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Rating>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).UserId);
        }

        [Fact]
        public async void TestListItemRatingsAsync()
                {
            Request[] requests = new Request[] {
                new ListItemRatings("item")
            };
        
            BatchResponse batchResponse = await client.SendAsync(new Batch(requests));
            Assert.Equal(200, (int)batchResponse.StatusCodes.ElementAt(0));
            Assert.Equal(1, ((IEnumerable<Rating>) batchResponse[0]).Count());
            Assert.Equal ("item",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).ItemId);
            Assert.Equal ("user",((IEnumerable<Rating>) batchResponse[0]).ElementAt(0).UserId);
        }
    }
}
