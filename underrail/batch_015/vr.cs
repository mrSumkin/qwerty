using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200051A RID: 1306
[eiz("GCE")]
[Serializable]
public sealed class vr : bjs, b2h, ISerializable
{
	// Token: 0x060021A1 RID: 8609 RVA: 0x000B380C File Offset: 0x000B1A0C
	private vr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("GCE:M");
		this.b = (Color?)A_0.GetValue("GCE:C", typeof(Color?));
		if (ell.a() >= 323)
		{
			this.c = (A_0.GetValue("GCE:I", typeof(coh)) as coh);
		}
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x000B3884 File Offset: 0x000B1A84
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GCE:M", this.a);
		info.AddValue("GCE:C", this.b);
		info.AddValue("GCE:I", this.c);
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x000B38D4 File Offset: 0x000B1AD4
	public string c()
	{
		return this.a;
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000B38DC File Offset: 0x000B1ADC
	public Color? d()
	{
		return this.b;
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000B38E4 File Offset: 0x000B1AE4
	public vr(ap9 A_0, ap9 A_1, string A_2, Color? A_3 = null, coh A_4 = null) : base(A_0, A_1)
	{
		this.a = A_2;
		this.b = A_3;
		this.c = A_4;
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000B3908 File Offset: 0x000B1B08
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		if (this.c != null)
		{
			string[] array = string.Format("- " + this.a, (base.h() != null) ? base.h().a() : base.i(), (base.f() != null) ? base.f().a() : base.i(), "~~~ ~~~").Split(new string[]
			{
				"~~~"
			}, StringSplitOptions.None);
			dl.a.Add(new bph((this.b != null) ? bvm.a(this.b.Value) : bvm.a(), array[0], null));
			if (array.Length > 1)
			{
				dl.a.AddRange(b94.a(this.c));
				if (array.Length > 2)
				{
					dl.a.Add(new bph((this.b != null) ? bvm.a(this.b.Value) : bvm.a(), array[2], null));
				}
			}
		}
		else
		{
			dl.a.Add(new bph((this.b != null) ? bvm.a(this.b.Value) : bvm.a(), string.Format("- " + this.a, (base.h() != null) ? base.h().a() : base.i(), (base.f() != null) ? base.f().a() : base.i(), base.g()), null));
		}
		return ecs;
	}

	// Token: 0x04001458 RID: 5208
	private new string a;

	// Token: 0x04001459 RID: 5209
	private new Color? b;

	// Token: 0x0400145A RID: 5210
	private coh c;
}
