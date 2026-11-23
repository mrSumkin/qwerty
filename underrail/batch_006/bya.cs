using System;
using System.Runtime.Serialization;

// Token: 0x020009E1 RID: 2529
[eiz("JYBSL")]
[Serializable]
public sealed class bya : bdw, ISerializable
{
	// Token: 0x06003C81 RID: 15489 RVA: 0x001669A4 File Offset: 0x00164BA4
	private bya(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C82 RID: 15490 RVA: 0x001669AC File Offset: 0x00164BAC
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x001669B0 File Offset: 0x00164BB0
	public bya()
	{
	}

	// Token: 0x06003C84 RID: 15492 RVA: 0x001669B8 File Offset: 0x00164BB8
	public void av(c1a A_0, cyt A_1)
	{
		string a_ = "BrodericksFerry";
		string str = "jy_broderickFerry_";
		bool value = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_isOnSilentIsle", new bool?(false)).Value;
		bool value2 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_ferryRemoveFromIsle", new bool?(false)).Value;
		bool value3 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_ferryRemoveFromJunkyard", new bool?(false)).Value;
		bool value4 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_dead", new bool?(false)).Value;
		bool value5 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_ferrySetStart", new bool?(false)).Value;
		bool value6 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_ferryIsOnIsle", new bool?(false)).Value;
		bool value7 = A_1.r().GetPrimitivePropertyValue<bool>("npc_broderick_ferrySailedBackByPlayer", new bool?(false)).Value;
		bool flag = false;
		if (!value5 && A_0.y8() == "jy5")
		{
			erb.a(A_1, A_0, str + "dirty", A_0.g(a_));
			A_1.r()["npc_broderick_ferrySetStart"] = true;
		}
		if (A_0.y8() == "si1")
		{
			if (value2)
			{
				if (!value)
				{
					erb.a(str + "clean", A_0.g(a_));
				}
				else
				{
					flag = true;
				}
				A_1.r()["npc_broderick_ferryRemoveFromIsle"] = false;
			}
			if (!value4 && value && !value6)
			{
				if (!flag)
				{
					erb.a(A_1, A_0, str + "clean", A_0.g(a_));
				}
				A_1.r()["npc_broderick_ferryRemoveFromJunkyard"] = true;
				A_1.r()["npc_broderick_ferryIsOnIsle"] = true;
				return;
			}
		}
		else
		{
			if (value3)
			{
				erb.a(str + "dirty", A_0.g(a_));
				A_1.r()["npc_broderick_ferryRemoveFromJunkyard"] = false;
			}
			if (value6 && ((!value4 && !value) || value7))
			{
				erb.a(A_1, A_0, str + "dirty", A_0.g(a_));
				A_1.r()["npc_broderick_ferryRemoveFromIsle"] = true;
				A_1.r()["npc_broderick_ferryIsOnIsle"] = false;
			}
		}
	}
}
