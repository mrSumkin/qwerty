using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000B6F RID: 2927
[eiz("FOSSMJ")]
[Serializable]
public sealed class bor : cze, ISerializable
{
	// Token: 0x060042FC RID: 17148 RVA: 0x001A29E0 File Offset: 0x001A0BE0
	private bor(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("FOSSMJ:A");
	}

	// Token: 0x060042FD RID: 17149 RVA: 0x001A29FC File Offset: 0x001A0BFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FOSSMJ:A", this.a);
	}

	// Token: 0x060042FE RID: 17150 RVA: 0x001A2A18 File Offset: 0x001A0C18
	public int a()
	{
		return this.a;
	}

	// Token: 0x060042FF RID: 17151 RVA: 0x001A2A20 File Offset: 0x001A0C20
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06004300 RID: 17152 RVA: 0x001A2A2C File Offset: 0x001A0C2C
	public bor()
	{
	}

	// Token: 0x06004301 RID: 17153 RVA: 0x001A2A38 File Offset: 0x001A0C38
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["loc_fo_meltedSupersteel"] = true;
			serviceOrThrow.aqu().r()["loc_fo_supersteelMeltingInProcess"] = true;
			serviceOrThrow.aqu().r()["loc_fo_amountOfSupersteelMelting"] = this.a;
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>("loc_fo_supersteelQualityImprovementIncrement", new int?(0)).Value;
			int num = dk2.b("xpbl") ? 20 : 15;
			int maxValue = (dk2.b("xpbl") && value >= 2) ? 181 : 161;
			int minValue = 70 + value * num;
			serviceOrThrow.aqu().r()["loc_fo_meltingFinishedTime"] = serviceOrThrow.aqu().p() + TimeSpan.FromMinutes(30.0);
			List<fv> list = new List<fv>();
			string path = "components\\MetalPlates\\Supersteel";
			if (ez2.GetItemDefinition<a1k>(path, true) != null)
			{
				for (int i = 0; i < this.a; i++)
				{
					list.Add(new fv(ez2.CreateDefinitonProvider<a1k>(path))
					{
						QualityLevel = cuo.a.Next(minValue, maxValue)
					});
				}
			}
			serviceOrThrow.aqu().r()["loc_fo_supersteelPlates"] = list;
		}
	}

	// Token: 0x04001C32 RID: 7218
	private new int a;
}
