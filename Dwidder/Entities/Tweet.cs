using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dwidder.Entities;

public class Tweet
{
    
}

public class TweetTypeConfiguration : IEntityTypeConfiguration<Tweet>
{
    public void Configure(EntityTypeBuilder<Tweet> builder)
    {
        throw new NotImplementedException();
    }
}