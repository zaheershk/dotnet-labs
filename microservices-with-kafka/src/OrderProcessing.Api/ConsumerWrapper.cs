namespace OrderProcessing.Api
{
    using Confluent.Kafka;
    using System;
    using System.Threading;

    public class ConsumerWrapper
    {
        private string _topicName;
        private ConsumerConfig _consumerConfig;

        public ConsumerWrapper(ConsumerConfig config, string topicName)
        {
            this._topicName = topicName;
            this._consumerConfig = config;
        }

        public string ReadMessage()
        {
            using var consumer = new ConsumerBuilder<Ignore, string>(_consumerConfig)
                .SetErrorHandler((_, e) => Console.WriteLine($"Error: {e.Reason}"))
                .Build();

            consumer.Subscribe(_topicName);

            var consumeResult = consumer.Consume();
            return consumeResult.Message?.Value;
        }
    }
}