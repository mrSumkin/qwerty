using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020004D1 RID: 1233
[eiz("MPMAPSC")]
[Serializable]
public sealed class dzi : dnh, ISerializable
{
	// Token: 0x06001F9E RID: 8094 RVA: 0x000ADC44 File Offset: 0x000ABE44
	private dzi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("MPMAPSC:MV");
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000ADC60 File Offset: 0x000ABE60
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MPMAPSC:MV", this.a);
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000ADC7C File Offset: 0x000ABE7C
	public int a()
	{
		return this.a;
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000ADC84 File Offset: 0x000ABE84
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x000ADC90 File Offset: 0x000ABE90
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
		{
			foreach (SkillEnum skillEnum in new SkillEnum[]
			{
				SkillEnum.Metathermics,
				SkillEnum.Psychokinesis,
				SkillEnum.ThoughtControl,
				SkillEnum.TemporalManipulation
			})
			{
				csn csn = serviceOrThrow.aqu().v().Skills.b(skillEnum.ToString().a());
				if (csn != null && csn.g() >= this.a)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000ADD34 File Offset: 0x000ABF34
	public dzi()
	{
	}

	// Token: 0x040013DA RID: 5082
	private int a;
}
