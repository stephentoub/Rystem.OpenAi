﻿namespace Rystem.OpenAi
{
    public static class ChatModelTypeExtensions
    {
        private static readonly Model s_gpt4 = new Model("gpt-4");
        private static readonly Model s_gpt4_32k = new Model("gpt-4-32k");
        private static readonly Model s_gpt4_snapshot = new Model("gpt-4-0613");
        private static readonly Model s_gpt4_32k_snapshot = new Model("gpt-4-32k-0613");
        private static readonly Model s_gpt_3_5_turbo = new Model("gpt-3.5-turbo");
        private static readonly Model s_gpt_3_5_turbo_16k = new Model("gpt-3.5-turbo-16k");
        private static readonly Model s_gpt_3_5_turbo_snapshot = new Model("gpt-3.5-turbo-0613");
        private static readonly Model s_gpt_3_5_turbo_16k_snapshot = new Model("gpt-3.5-turbo-16k-0613");
        public static Model ToModel(this ChatModelType type)
        {
            return type switch
            {
                ChatModelType.Gpt35Turbo => s_gpt_3_5_turbo,
                ChatModelType.Gpt35Turbo_16K => s_gpt_3_5_turbo_16k,
                ChatModelType.Gpt35Turbo_Snapshot => s_gpt_3_5_turbo_snapshot,
                ChatModelType.Gpt35Turbo_16K_Snapshot => s_gpt_3_5_turbo_16k_snapshot,
                ChatModelType.Gpt4 => s_gpt4,
                ChatModelType.Gpt4_32K => s_gpt4_32k,
                ChatModelType.Gpt4_Snapshot => s_gpt4_snapshot,
                ChatModelType.Gpt4_32K_Snapshot => s_gpt4_32k_snapshot,
                _ => s_gpt_3_5_turbo,
            };
        }
        public static ModelFamilyType ToFamily(this ChatModelType type)
        {
            return type switch
            {
                ChatModelType.Gpt35Turbo => ModelFamilyType.Gpt3_5,
                ChatModelType.Gpt35Turbo_16K => ModelFamilyType.Gpt3_5_16K,
                ChatModelType.Gpt35Turbo_Snapshot => ModelFamilyType.Gpt3_5,
                ChatModelType.Gpt35Turbo_16K_Snapshot => ModelFamilyType.Gpt3_5_16K,
                ChatModelType.Gpt4 => ModelFamilyType.Gpt4_8K,
                ChatModelType.Gpt4_32K => ModelFamilyType.Gpt4_32K,
                ChatModelType.Gpt4_Snapshot => ModelFamilyType.Gpt4_8K,
                ChatModelType.Gpt4_32K_Snapshot => ModelFamilyType.Gpt4_32K,
                _ => ModelFamilyType.Gpt3_5,
            };
        }
        public static string ToModelId(this ChatModelType type)
            => type.ToModel().Id!;
    }
}
