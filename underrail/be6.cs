using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200111E RID: 4382
[eiz("ATJ")]
[Serializable]
public sealed class be6 : cze, ISerializable
{
	// Token: 0x06005D84 RID: 23940 RVA: 0x0027BBB8 File Offset: 0x00279DB8
	private be6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("ATJ:DW");
			if (ell.a() >= 189)
			{
				this.b = A_0.GetBoolean("ATJ:C");
			}
			else
			{
				this.b = true;
			}
			if (ell.a() >= 273)
			{
				this.c = (Guid?)A_0.GetValue("ATJ:I", typeof(Guid?));
				this.d = A_0.GetString("ATJ:A");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(be6))
			{
				this.a = A_0.GetString("_DestinationWaypoint");
				return;
			}
			this.a = A_0.GetString("AreaTransitionJob+_DestinationWaypoint");
		}
	}

	// Token: 0x06005D85 RID: 23941 RVA: 0x0027BC94 File Offset: 0x00279E94
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATJ:DW", this.a);
		info.AddValue("ATJ:C", this.b);
		info.AddValue("ATJ:I", this.c);
		info.AddValue("ATJ:A", this.d);
	}

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x06005D86 RID: 23942 RVA: 0x0027BCF4 File Offset: 0x00279EF4
	// (set) Token: 0x06005D87 RID: 23943 RVA: 0x0027BCFC File Offset: 0x00279EFC
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

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x06005D88 RID: 23944 RVA: 0x0027BD08 File Offset: 0x00279F08
	// (set) Token: 0x06005D89 RID: 23945 RVA: 0x0027BD10 File Offset: 0x00279F10
	public bool CancelActionsOnTransition
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

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06005D8A RID: 23946 RVA: 0x0027BD1C File Offset: 0x00279F1C
	// (set) Token: 0x06005D8B RID: 23947 RVA: 0x0027BD24 File Offset: 0x00279F24
	public string OverrideTargetArea
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06005D8C RID: 23948 RVA: 0x0027BD30 File Offset: 0x00279F30
	// (set) Token: 0x06005D8D RID: 23949 RVA: 0x0027BD38 File Offset: 0x00279F38
	public Guid? OverrideTargetId
	{
		get
		{
			return this.c;
		}
		set
		{
			this.c = value;
		}
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x0027BD44 File Offset: 0x00279F44
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.d);
				}
			}
			else if (A_0 != null)
			{
				aud = A_0.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_0 as c5x);
		}
		if (c5x != null)
		{
			a0l.a(c5x, this.a, this.b);
		}
	}

	// Token: 0x06005D8F RID: 23951 RVA: 0x0027BE0C File Offset: 0x0027A00C
	public be6()
	{
	}

	// Token: 0x04002540 RID: 9536
	private new string a;

	// Token: 0x04002541 RID: 9537
	private bool b;

	// Token: 0x04002542 RID: 9538
	private Guid? c;

	// Token: 0x04002543 RID: 9539
	private string d;
}
