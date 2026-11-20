using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A8C RID: 6796
[eiz("PTSSS")]
[Serializable]
public sealed class ck3 : els, ISerializable
{
	// Token: 0x0600938C RID: 37772 RVA: 0x003A2D20 File Offset: 0x003A0F20
	private ck3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600938D RID: 37773 RVA: 0x003A2D2C File Offset: 0x003A0F2C
	public ck3() : base(ck3.b, "Псионический трансивер", ci8.b)
	{
		base.Icon = "Status.PsionicTransceiver";
		base.MaxStacks = 99;
		base.Stacking = axm.b;
		base.Duration = ck3.c;
		this.c8();
	}

	// Token: 0x0600938E RID: 37774 RVA: 0x003A2D78 File Offset: 0x003A0F78
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsionicTransceiver", new object[]
		{
			ck3.a(base.Stacks)
		});
	}

	// Token: 0x0600938F RID: 37775 RVA: 0x003A2DA0 File Offset: 0x003A0FA0
	protected override void c8()
	{
		base.c8();
		foreach (SkillEnum skillEnum in new SkillEnum[]
		{
			SkillEnum.Metathermics,
			SkillEnum.Psychokinesis,
			SkillEnum.ThoughtControl,
			SkillEnum.TemporalManipulation
		})
		{
			ck3.a a = new ck3.a();
			a.a = skillEnum.a();
			dpw dpw = Enumerable.FirstOrDefault<dpw>(Enumerable.Where<dpw>(Enumerable.OfType<dpw>(base.StaticEffects), new Func<dpw, bool>(a.a)));
			if (dpw == null)
			{
				dpw = new dpw(a.a, ck3.a(base.Stacks));
				base.StaticEffects.Add(dpw);
			}
			else
			{
				dpw.a(ck3.a(base.Stacks));
			}
		}
	}

	// Token: 0x06009390 RID: 37776 RVA: 0x003A2E64 File Offset: 0x003A1064
	private static int a(int A_0)
	{
		return A_0 * ck3.a;
	}

	// Token: 0x040038AE RID: 14510
	public new static readonly int a = 1;

	// Token: 0x040038AF RID: 14511
	public static readonly string b = "psionicTransceiver";

	// Token: 0x040038B0 RID: 14512
	private new static readonly int c = 6000;

	// Token: 0x02001A8D RID: 6797
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06009393 RID: 37779 RVA: 0x003A2E94 File Offset: 0x003A1094
		internal bool a(dpw A_0)
		{
			return A_0.SkillName == this.a;
		}

		// Token: 0x040038B1 RID: 14513
		public string a;
	}
}
