using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001210 RID: 4624
[eiz("DT")]
[Serializable]
public sealed class b3o : cca, ISerializable
{
	// Token: 0x06006354 RID: 25428 RVA: 0x002ADE20 File Offset: 0x002AC020
	private b3o(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("DT:T");
		this.b = (m4)A_0.GetValue("DT:DT", typeof(m4));
		this.c = A_0.GetInt32("DT:XP");
	}

	// Token: 0x06006355 RID: 25429 RVA: 0x002ADE78 File Offset: 0x002AC078
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DT:T", this.a);
		info.AddValue("DT:DT", this.b);
		info.AddValue("DT:XP", this.c);
	}

	// Token: 0x06006356 RID: 25430 RVA: 0x002ADEC8 File Offset: 0x002AC0C8
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006357 RID: 25431 RVA: 0x002ADED0 File Offset: 0x002AC0D0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006358 RID: 25432 RVA: 0x002ADEDC File Offset: 0x002AC0DC
	public m4 c()
	{
		return this.b;
	}

	// Token: 0x06006359 RID: 25433 RVA: 0x002ADEE4 File Offset: 0x002AC0E4
	public void a(m4 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600635A RID: 25434 RVA: 0x002ADEF0 File Offset: 0x002AC0F0
	public int b()
	{
		return this.c;
	}

	// Token: 0x0600635B RID: 25435 RVA: 0x002ADEF8 File Offset: 0x002AC0F8
	public void a(int A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600635C RID: 25436 RVA: 0x002ADF04 File Offset: 0x002AC104
	public b3o()
	{
	}

	// Token: 0x0600635D RID: 25437 RVA: 0x002ADF0C File Offset: 0x002AC10C
	protected override void adf(c5x A_0)
	{
		bpo.GetServiceOrThrow<ps>();
		ecs ecs = null;
		string a_ = null;
		m4 m = this.b;
		if (m != global::m4.a)
		{
			if (m == global::m4.b)
			{
				ecs = new ecs(new List<dl6>
				{
					new dl6(new List<bph>
					{
						new bph(new d22(b94.a(), Color.Yellow), "Охраняемая зона доступна" + ((!string.IsNullOrEmpty(this.a)) ? ": " : ""), null)
					})
				});
				if (!string.IsNullOrEmpty(this.a))
				{
					ecs.a[0].a.Add(new bph(new d22(b94.a(), adi.c), this.a, null));
				}
				a_ = "доступ к охраняемой зоне";
			}
		}
		else
		{
			ecs = null;
			a_ = this.a;
		}
		e3q e3q = null;
		if (A_0 != null && A_0.h.b != null)
		{
			e3q = (A_0.h.b.aa() as e3q);
		}
		if (this.c > 0 && A_0 != null && A_0.h.b != null && e3q != null && e3q.e() == ExperienceSystem.Classic)
		{
			A_0.h.b.a(this.c, a_);
		}
		if (ecs != null)
		{
			a7v.a(new ky(ecs, null));
		}
	}

	// Token: 0x040029D7 RID: 10711
	private string a;

	// Token: 0x040029D8 RID: 10712
	private m4 b;

	// Token: 0x040029D9 RID: 10713
	private int c;
}
