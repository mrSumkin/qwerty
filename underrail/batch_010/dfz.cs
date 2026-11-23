using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02000684 RID: 1668
public static class dfz
{
	// Token: 0x06002ADD RID: 10973 RVA: 0x000F4CE0 File Offset: 0x000F2EE0
	static dfz()
	{
		dfz.a["merchant"] = new bs7("торговец", Color.Gold);
		dfz.a["doctor"] = new bs7("доктор", Color.LightGreen);
		dfz.a["elevator"] = new bs7("лифт", Color.LightGreen);
		dfz.a["switch"] = new bs7("рубильник", Color.LightGray);
		dfz.a["powerGenerator"] = new bs7("генератор", new Color(191, 243, 255));
		dfz.a["secretPassage"] = new bs7("секретный проход", Color.Pink);
		dfz.a["rift"] = new bs7("разлом", new Color(78, 224, 191));
		dfz.a["organicProcessor"] = new bs7("органический процессор", Color.Gold);
		dfz.a["mysteriousPillars"] = new bs7("загадочные монолиты", new Color(136, 208, 255));
		dfz.a["ferryman"] = new bs7("паромщик", Color.BurlyWood);
		dfz.a["mindshroom"] = new bs7("мозгляк", Color.DodgerBlue);
		dfz.a["glittershroom"] = new bs7("блестящий гриб", Color.HotPink);
		dfz.a["greenWart"] = new bs7("зелёная бородавка", Color.MediumSeaGreen);
		dfz.a["honeyStalks"] = new bs7("медоносные стебли", Color.Goldenrod);
		dfz.a["lingula"] = new bs7("лингула", Color.Sienna);
		dfz.a["spiritMushroom"] = new bs7("призрачный гриб", Color.Gray);
		dfz.a["oozingShroom"] = new bs7("сочащийся гриб", Color.Fuchsia);
		dfz.a["redDreamMushroom"] = new bs7("гриб красный сон", new Color(255, 50, 50));
		dfz.a["lakePoppy"] = new bs7("озёрный мак", Color.DarkSeaGreen);
		dfz.a["gremlinStool"] = new bs7("гремлинская поганка", Color.DarkKhaki);
		dfz.a["caveEars"] = new bs7("пещерное ухо", Color.DarkOliveGreen);
		dfz.a["greenWart"] = new bs7("зелёная бородавка", Color.SeaGreen);
		dfz.a["lingula"] = new bs7("лингула", Color.Olive);
		dfz.a["glittershroom"] = new bs7("блестящий гриб", Color.Magenta);
		dfz.a["honeyStalks"] = new bs7("медоносные стебли", Color.Orange);
		dfz.a["rathound"] = new bs7("крысоволк", Color.Red);
		dfz.a["ancientRathound"] = new bs7("древний крысоволк", Color.Red);
		dfz.a["moleCricket"] = new bs7("медведка", Color.Brown);
		dfz.a["cavehopper"] = new bs7("пещерник", Color.LightSkyBlue);
		dfz.a["psiBeetle"] = new bs7("пси-жук", Color.Red);
		dfz.a["crawler"] = new bs7("краулер", Color.Red);
		dfz.a["burrower"] = new bs7("могильщик", Color.Red);
		dfz.a["pig"] = new bs7("свинья", Color.Red);
		dfz.a["mutatedDog"] = new bs7("мутировавшая собака", Color.Red);
		dfz.a["mutant"] = new bs7("мутант", Color.Red);
		dfz.a["bladeling"] = new bs7("меченосец", Color.Red);
		dfz.a["coilSpider"] = new bs7("электропаук", Color.Red);
		dfz.a["tchortling"] = new bs7("чортист", Color.Red);
		dfz.a["cuttlesnail"] = new bs7("улитица", Color.Red);
		dfz.a["siphoner"] = new bs7("брызгун", Color.Red);
		dfz.a["crab"] = new bs7("гигантский краб", Color.Red);
		dfz.a["buffalo"] = new bs7("бизон", Color.Red);
		dfz.a["seaWyrm"] = new bs7("морской змий", Color.Red);
		dfz.a["leperSerpent"] = new bs7("прокажённый змей", Color.Red);
		dfz.a["heartbreaker"] = new bs7("сердцеед", Color.Red);
		dfz.a["hive"] = new bs7("улей саранчи", Color.Red);
		dfz.a["giantCreeper"] = new bs7("гигантский ползун", Color.Red);
		dfz.a["hermit"] = new bs7("гигантский краб отшельник", Color.Red);
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x000F52CC File Offset: 0x000F34CC
	public static bs7 a(string A_0)
	{
		bs7 result;
		dfz.a.TryGetValue(A_0, out result);
		return result;
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x000F52E8 File Offset: 0x000F34E8
	public static string a(string A_0, string A_1)
	{
		string text = A_0.ToLowerInvariant();
		string text2 = A_1.ToLowerInvariant();
		string result;
		if (string.CompareOrdinal(text, text2) <= 0)
		{
			result = string.Format("{0}-{1}", text, text2);
		}
		else
		{
			result = string.Format("{0}-{1}", text2, text);
		}
		return result;
	}

	// Token: 0x04001744 RID: 5956
	private static readonly Dictionary<string, bs7> a = new Dictionary<string, bs7>();
}
