using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001B3C RID: 6972
[eiz("PWSE")]
[Serializable]
public sealed class ag0 : els, ISerializable
{
	// Token: 0x060096C6 RID: 38598 RVA: 0x003AEC28 File Offset: 0x003ACE28
	private ag0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.d = (A_0.GetValue("PWSE:E", typeof(ag8)) as ag8);
		di7.ReadList<ax6>("PWSE:BAM", ref this.e, A_0);
	}

	// Token: 0x060096C7 RID: 38599 RVA: 0x003AEC7C File Offset: 0x003ACE7C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		di7.WriteList<ax6>("PWSE:BAM", this.e, info);
		info.AddValue("PWSE:E", this.d);
	}

	// Token: 0x060096C8 RID: 38600 RVA: 0x003AECAC File Offset: 0x003ACEAC
	public ag0(int A_0) : base("psionicWithdrawal", "Псионическое похмелье", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.PsionicWithdrawal";
		base.MaxStacks = 10;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		this.d = new ag8(-ag0.c, true);
		base.DynamicEffects.Add(this.d);
		int num = this.a();
		this.e = new List<ax6>
		{
			new ax6(to.a(typeof(av8)), -num),
			new ax6(to.a(typeof(eav)), -num),
			new ax6(to.a(typeof(axr)), -num)
		};
		foreach (ax6 item in this.e)
		{
			base.StaticEffects.Add(item);
		}
	}

	// Token: 0x060096C9 RID: 38601 RVA: 0x003AEDDC File Offset: 0x003ACFDC
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsionicWithdrawal", new object[]
		{
			Math.Abs(this.d.a()),
			this.a()
		});
	}

	// Token: 0x060096CA RID: 38602 RVA: 0x003AEE20 File Offset: 0x003AD020
	protected override void c8()
	{
		base.c8();
		if (this.d != null)
		{
			this.d.a(-ag0.c * base.Stacks);
		}
		if (this.e != null)
		{
			foreach (ax6 ax in this.e)
			{
				ax.a((int)Math.Ceiling((double)(-(double)(this.a * (float)base.Stacks))));
			}
		}
	}

	// Token: 0x060096CB RID: 38603 RVA: 0x003AEEC0 File Offset: 0x003AD0C0
	private int a()
	{
		return (int)Math.Ceiling((double)(this.a * (float)base.Stacks));
	}

	// Token: 0x040039FC RID: 14844
	private new readonly float a = 1f;

	// Token: 0x040039FD RID: 14845
	public static readonly int b = 30000;

	// Token: 0x040039FE RID: 14846
	private new static readonly int c = 5;

	// Token: 0x040039FF RID: 14847
	private new ag8 d;

	// Token: 0x04003A00 RID: 14848
	private new List<ax6> e;
}
