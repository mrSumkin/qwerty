using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001041 RID: 4161
[eiz("SCMS1")]
[Serializable]
public sealed class aau : cze, ISerializable
{
	// Token: 0x06005611 RID: 22033 RVA: 0x0025DE2C File Offset: 0x0025C02C
	private aau(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (float)A_0.GetValue("SCMS1:MS", typeof(float));
		this.b = A_0.GetBoolean("SCMS1:SUA");
		this.c = (Guid?)A_0.GetValue("SCMS1:ORI", typeof(Guid?));
		this.d = A_0.GetString("SCMS1:A");
	}

	// Token: 0x06005612 RID: 22034 RVA: 0x0025DEB0 File Offset: 0x0025C0B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCMS1:MS", this.a);
		info.AddValue("SCMS1:SUA", this.b);
		info.AddValue("SCMS1:ORI", this.c);
		info.AddValue("SCMS1:A", this.d);
	}

	// Token: 0x06005613 RID: 22035 RVA: 0x0025DF10 File Offset: 0x0025C110
	public float c()
	{
		return this.a;
	}

	// Token: 0x06005614 RID: 22036 RVA: 0x0025DF18 File Offset: 0x0025C118
	public void a(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005615 RID: 22037 RVA: 0x0025DF24 File Offset: 0x0025C124
	public bool d()
	{
		return this.b;
	}

	// Token: 0x06005616 RID: 22038 RVA: 0x0025DF2C File Offset: 0x0025C12C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005617 RID: 22039 RVA: 0x0025DF38 File Offset: 0x0025C138
	public Guid? a()
	{
		return this.c;
	}

	// Token: 0x06005618 RID: 22040 RVA: 0x0025DF40 File Offset: 0x0025C140
	public void a(Guid? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005619 RID: 22041 RVA: 0x0025DF4C File Offset: 0x0025C14C
	public string b()
	{
		return this.d;
	}

	// Token: 0x0600561A RID: 22042 RVA: 0x0025DF54 File Offset: 0x0025C154
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600561B RID: 22043 RVA: 0x0025DF60 File Offset: 0x0025C160
	public aau()
	{
	}

	// Token: 0x0600561C RID: 22044 RVA: 0x0025DF78 File Offset: 0x0025C178
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.c != null)
		{
			aud aud = null;
			if (this.d != null)
			{
				if (A_0 != null)
				{
					aud = A_0.Zone.n(this.d);
				}
				else
				{
					aud = A_1.Zone.n(this.d);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.c.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null && c5x.h.b != null)
		{
			c5x.h.b.aa().BaseMovementSpeed = this.a;
			c5x.h.b.aa().bl();
			if (this.b)
			{
				a6p aspect = c5x.GetAspect<a6p>();
				if (aspect != null && !aspect.d().Contains("-modifiers"))
				{
					aspect.d().Add("-modifiers");
				}
			}
		}
	}

	// Token: 0x040022F6 RID: 8950
	private new float a = 1f;

	// Token: 0x040022F7 RID: 8951
	private bool b;

	// Token: 0x040022F8 RID: 8952
	private Guid? c;

	// Token: 0x040022F9 RID: 8953
	private string d;
}
