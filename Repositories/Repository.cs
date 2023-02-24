using MongoDB.Driver;


public class Repository<TEntity>
{
    const string DATABASE_NAME = "fitnessdb";

    private readonly MongoClient mongoClient;
    private readonly IMongoCollection<TEntity> collection;

    public Repository(MongoClient mongoClient)
    {
        this.mongoClient = mongoClient;
        var database = mongoClient.GetDatabase(DATABASE_NAME);
        this.collection = database.GetCollection<TEntity>(typeof(TEntity).FullName.Split('.').Last().ToLower());
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        await collection.InsertOneAsync(entity);
        return entity;
    }

    public async Task<IEnumerable<TEntity>> FindAsync(FilterDefinition<TEntity> filter)
    {
        return (await collection.FindAsync(filter)).ToEnumerable();
    }
}