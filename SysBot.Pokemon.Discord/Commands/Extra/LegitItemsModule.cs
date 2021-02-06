using Discord;
using Discord.Commands;
using PKHeX.Core;
using System.Linq;
using System.Threading.Tasks;

namespace SysBot.Pokemon.Discord
{
    [Summary("LegitForce Item-Delivery-Service")]
    public class LegitItemsModule : ModuleBase<SocketCommandContext>
    {
        private static TradeQueueInfo<PK8> Info => SysCordInstance.Self.Hub.Queues.Info;

        string head = "Deliverbird (delibird) @ ";

        [Command("wishingpiece")]
        [Alias("wp")]
        [Summary("Makes the bot trade you a mon holding an Wishing Piece")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeWpAsync()
        {
            string content = head + "wishing piece";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("masterball")]
        [Alias("mb")]
        [Summary("Makes the bot trade you a mon holding an Master Ball")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeMbAsync()
        {
            string content = head + "master ball";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("beastball")]
        [Alias("bb")]
        [Summary("Makes the bot trade you a mon holding an Beast Ball")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeBbAsync()
        {
            string content = head + "beast ball";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("goldbottlecap")]
        [Alias("gbc")]
        [Summary("Makes the bot trade you a mon holding an Gold Bottle Cap")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeGbcAsync()
        {
            string content = head + "gold bottle cap";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("abilitycapsule")]
        [Alias("ac")]
        [Summary("Makes the bot trade you a mon holding an Ability Capsule")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeAcAsync()
        {
            string content = head + "ability capsule";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("abilitypatch")]
        [Alias("ap")]
        [Summary("Makes the bot trade you a mon holding an Ability Patch")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeApAsync()
        {
            string content = head + "ability patch";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("weaknesspolicy")]
        [Alias("wepo")]
        [Summary("Makes the bot trade you a mon holding an Weakness Policy")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeWepoAsync()
        {
            string content = head + "weakness policy";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("lifeorb")]
        [Alias("lorb")]
        [Summary("Makes the bot trade you a mon holding an Life Orb")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeLorbAsync()
        {
            string content = head + "life orb";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("rustedsword")]
        [Alias("rsw")]
        [Summary("Makes the bot trade you a mon holding an Rusted Sword")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeRswAsync()
        {
            string content = head + "rusted sword";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("rustedshield")]
        [Alias("rsh")]
        [Summary("Makes the bot trade you a mon holding an Rusted Shield")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeRshAsync()
        {
            string content = head + "rusted shield";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("rarecandy")]
        [Alias("rc")]
        [Summary("Makes the bot trade you a mon holding an Rare Candy")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeRcAsync()
        {
            string content = head + "rare candy";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("maxmushroom")]
        [Alias("mm")]
        [Summary("Makes the bot trade you a mon holding an Max Mushroom")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeMmAsync()
        {
            string content = head + "max mushrooms";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("choiceband")]
        [Alias("cba")]
        [Summary("Makes the bot trade you a mon holding an Choice Band")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeCbaAsync()
        {
            string content = head + "choice band";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("choicescarf")]
        [Alias("csc")]
        [Summary("Makes the bot trade you a mon holding an Choice Scarf")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeCscAsync()
        {
            string content = head + "choice scarf";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        [Command("choicespecs")]
        [Alias("csp")]
        [Summary("Makes the bot trade you a mon holding Choice Specs")]
        [RequireQueueRole(nameof(DiscordManager.RolesTrade))]
        public async Task TradeCspAsync()
        {
            string content = head + "choice specs";
            var code = Info.GetRandomTradeCode();
            await TradeAsync(code, content).ConfigureAwait(false);
        }

        public async Task TradeAsync([Summary("Trade Code")] int code, [Summary("Showdown Set")][Remainder] string content)
        {
            const int gen = 8;
            content = ReusableActions.StripCodeBlock(content);
            var set = new ShowdownSet(content);
            var template = AutoLegalityWrapper.GetTemplate(set);

            if (set.InvalidLines.Count != 0)
            {
                var msg = $"Unable to parse Showdown Set:\n{string.Join("\n", set.InvalidLines)}";
                await ReplyAsync(msg).ConfigureAwait(false);
                return;
            }

            var sav = AutoLegalityWrapper.GetTrainerInfo(gen);
            var pkm = sav.GetLegal(template, out _);
            pkm.ResetPartyStats();
            var sig = Context.User.GetFavor();
            await AddTradeToQueueAsync(code, Context.User.Username, (PK8)pkm, sig).ConfigureAwait(false);
        }

        private async Task<bool> TrollAsync(bool invalid, IBattleTemplate set)
        {
            var rng = new System.Random();
            var path = Info.Hub.Config.Trade.MemeFileNames.Split(',');
            var msg = $"Oops! I wasn't able to create that {GameInfo.Strings.Species[set.Species]}. Here's a meme instead!\n";

            if (path.Length == 0)
                path = new string[] { "https://i.imgur.com/qaCwr09.png" }; //If memes enabled but none provided, use a default one.

            if (invalid || !ItemRestrictions.IsHeldItemAllowed(set.HeldItem, 8) || (Info.Hub.Config.Trade.ItemMuleSpecies != Species.None && set.Shiny) || Info.Hub.Config.Trade.EggTrade && set.Nickname == "Egg" && set.Species >= 888
                || (Info.Hub.Config.Trade.ItemMuleSpecies != Species.None && GameInfo.Strings.Species[set.Species] != Info.Hub.Config.Trade.ItemMuleSpecies.ToString() && !(Info.Hub.Config.Trade.DittoTrade && set.Species == 132 || Info.Hub.Config.Trade.EggTrade && set.Nickname == "Egg" && set.Species < 888)))
            {
                if (Info.Hub.Config.Trade.MemeFileNames.Contains(".com") || path.Length == 0)
                    _ = invalid == true ? await Context.Channel.SendMessageAsync($"{msg}{path[rng.Next(path.Length)]}").ConfigureAwait(false) : await Context.Channel.SendMessageAsync($"{path[rng.Next(path.Length)]}").ConfigureAwait(false);
                else _ = invalid == true ? await Context.Channel.SendMessageAsync($"{msg}{path[rng.Next(path.Length)]}").ConfigureAwait(false) : await Context.Channel.SendMessageAsync($"{path[rng.Next(path.Length)]}").ConfigureAwait(false);
                return true;
            }
            return false;
        }

        private async Task AddTradeToQueueAsync(int code, string trainerName, PK8 pk8, RequestSignificance sig)
        {
            if (!pk8.CanBeTraded() || !new TradeExtensions(Info.Hub).IsItemMule(pk8))
            {
                var msg = "Provided Pokémon content is blocked from trading!";
                await ReplyAsync($"{(!Info.Hub.Config.Trade.ItemMuleCustomMessage.Equals(string.Empty) && !Info.Hub.Config.Trade.ItemMuleSpecies.Equals(Species.None) ? Info.Hub.Config.Trade.ItemMuleCustomMessage : msg)}").ConfigureAwait(false);
                return;
            }

            if (Info.Hub.Config.Trade.DittoTrade && pk8.Species == 132)
                TradeExtensions.DittoTrade(pk8);

            if (Info.Hub.Config.Trade.EggTrade && pk8.Nickname == "Egg")
                TradeExtensions.EggTrade(pk8);

            await Context.AddToQueueAsync(code, trainerName, sig, pk8, PokeRoutineType.LinkTrade, PokeTradeType.Specific).ConfigureAwait(false);
        }
    }
}
