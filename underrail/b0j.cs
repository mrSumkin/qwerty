using System;
using System.ComponentModel;
using System.Runtime.Serialization;

// Token: 0x02001216 RID: 4630
[eiz("ATT")]
[Serializable]
public sealed class b0j : ya, ISerializable
{
	// Token: 0x060063A8 RID: 25512 RVA: 0x002AF13C File Offset: 0x002AD33C
	private b0j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("ATT:DW");
			if (ell.a() >= 472)
			{
				this.b = (A_0.GetValue("ATT:C", typeof(dth)) as dth);
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(b0j))
			{
				this.a = A_0.GetString("_DestinationWaypoint");
				return;
			}
			this.a = A_0.GetString("AreaTransitionTrigger+_DestinationWaypoint");
		}
	}

	// Token: 0x060063A9 RID: 25513 RVA: 0x002AF1DC File Offset: 0x002AD3DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATT:DW", this.a);
		info.AddValue("ATT:C", this.b);
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x060063AA RID: 25514 RVA: 0x002AF208 File Offset: 0x002AD408
	// (set) Token: 0x060063AB RID: 25515 RVA: 0x002AF210 File Offset: 0x002AD410
	[Browsable(false)]
	public dth Condition
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

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x060063AC RID: 25516 RVA: 0x002AF21C File Offset: 0x002AD41C
	// (set) Token: 0x060063AD RID: 25517 RVA: 0x002AF224 File Offset: 0x002AD424
	[Category("Behavior")]
	public string DestinationWaypoint
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

	// Token: 0x060063AE RID: 25518 RVA: 0x002AF230 File Offset: 0x002AD430
	public b0j()
	{
	}

	// Token: 0x060063AF RID: 25519 RVA: 0x002AF23C File Offset: 0x002AD43C
	protected override void ac2(b0b A_0)
	{
		if (!string.IsNullOrEmpty(this.a) && base.Area != null && base.Area.Zone != null)
		{
			c5x c5x = A_0 as c5x;
			if (c5x != null)
			{
				a0l.a(c5x, this.a, true);
			}
		}
	}

	// Token: 0x040029F3 RID: 10739
	private string a;

	// Token: 0x040029F4 RID: 10740
	private dth b;
}
