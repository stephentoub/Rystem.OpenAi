﻿using System.Collections.Generic;
using System.Net.Http;

namespace Rystem.OpenAi.Completion
{
    internal sealed class OpenAiCompletion : OpenAiBase, IOpenAiCompletion, IOpenAiCompletionApi
    {
        public OpenAiCompletion(IHttpClientFactory httpClientFactory,
            IEnumerable<OpenAiConfiguration> configurations,
            IOpenAiUtility utility)
            : base(httpClientFactory, configurations, utility)
        {
        }
        public CompletionRequestBuilder Request(params string[] prompts)
            => new CompletionRequestBuilder(Client, Configuration, prompts, Utility);
    }
}