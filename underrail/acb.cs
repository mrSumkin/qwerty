using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules;

// Token: 0x020008EB RID: 2283
[eiz("GENSGGF")]
[Serializable]
public sealed class acb : bdw, ISerializable
{
	// Token: 0x06003898 RID: 14488 RVA: 0x0014F370 File Offset: 0x0014D570
	private acb(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003899 RID: 14489 RVA: 0x0014F378 File Offset: 0x0014D578
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x0014F37C File Offset: 0x0014D57C
	public acb()
	{
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x0014F388 File Offset: 0x0014D588
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0.ElapsedZoneTime <= TimeSpan.Zero)
		{
			foreach (csd csd in Enumerable.ToList<csd>(A_0.Waypoints))
			{
				if (csd.Name.StartsWith("genGang_"))
				{
					string[] array = csd.Name.Split(new char[]
					{
						'_'
					}, 4);
					if (this.a(array[2]))
					{
						string a = array[1];
						string a_;
						if (!(a == "ironhead"))
						{
							if (!(a == "lurker"))
							{
								if (!(a == "lunatic"))
								{
									continue;
								}
								a_ = "Lunatics";
							}
							else
							{
								a_ = "Lurkers";
							}
						}
						else
						{
							a_ = "Ironheads";
						}
						if (!aw1.a(csd.Tile, false, null, l9.a))
						{
							bfc bfc = A_1.h();
							gx gx = new gx();
							int num = 0;
							if (array[2] == "dominating")
							{
								num = 5;
							}
							else if (array[2] == "hard")
							{
								num = 2;
							}
							gx.a(csd, new int?(((bfc == null) ? 20 : bfc.BaseLevel) + num), a_, null, null, null, null, false, null, false);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600389C RID: 14492 RVA: 0x0014F528 File Offset: 0x0014D728
	private bool a(string A_0)
	{
		bu6 service = bpo.GetService<bu6>();
		GameDifficulty gameDifficulty;
		Enum.TryParse<GameDifficulty>(A_0, true, out gameDifficulty);
		return service.aq2() >= gameDifficulty;
	}
}
