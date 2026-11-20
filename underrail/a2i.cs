using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001059 RID: 4185
[eiz("OSCDJ")]
[Serializable]
public sealed class a2i : cze
{
	// Token: 0x060056E3 RID: 22243 RVA: 0x00260BF4 File Offset: 0x0025EDF4
	private a2i(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("OSCDJ:I", typeof(Guid?));
		this.b = A_0.GetString("OSCDJ:A");
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x00260C30 File Offset: 0x0025EE30
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("OSCDJ:I", this.a);
		info.AddValue("OSCDJ:A", this.b);
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x060056E5 RID: 22245 RVA: 0x00260C64 File Offset: 0x0025EE64
	// (set) Token: 0x060056E6 RID: 22246 RVA: 0x00260C6C File Offset: 0x0025EE6C
	public string OverrideTargetArea
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x060056E7 RID: 22247 RVA: 0x00260C78 File Offset: 0x0025EE78
	// (set) Token: 0x060056E8 RID: 22248 RVA: 0x00260C80 File Offset: 0x0025EE80
	public Guid? OverrideTargetId
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060056E9 RID: 22249 RVA: 0x00260C8C File Offset: 0x0025EE8C
	public a2i()
	{
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x00260C98 File Offset: 0x0025EE98
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.a != null)
		{
			aud aud = cze.a(this.b, A_0, A_1, A_2);
			if (aud != null)
			{
				c5x = (aud.a(this.a.Value) as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x c5x2 = new c5x();
			c5x2.Size = c5x.Size;
			c5x2.Location = c5x.Location;
			c5x2.VisualPriority = c5x.VisualPriority;
			c5x2.Layer = aju.x;
			cd0 cd = new cd0(c5x2);
			cd.a = "Walls\\CaveLuxHiddenDoorAnim";
			if (c5x.Size.Y > 1f)
			{
				cd.b = new Point(0, 1);
			}
			c5x2.SetAspect<cd0>(cd);
			ny ny = new ny(c5x2);
			c5x2.SetAspect<ny>(ny);
			c5x.Area.a(c5x2);
			c5x.w();
			c5x.an();
			dqm dqm = new dqm(cd);
			dqm.a(250.0);
			dqm.c(5);
			ny.b(dqm, atp.a);
			c5x2.c().a("SecretCaveDoorOpen");
		}
	}

	// Token: 0x04002338 RID: 9016
	private new Guid? a;

	// Token: 0x04002339 RID: 9017
	private string b;
}
