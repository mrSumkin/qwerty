using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001060 RID: 4192
[eiz("FRMSJ1")]
[Serializable]
public sealed class eiw : cze, ISerializable
{
	// Token: 0x0600570B RID: 22283 RVA: 0x00261990 File Offset: 0x0025FB90
	private eiw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("FRMSJ1:I", typeof(Guid?));
		this.b = A_0.GetString("FRMSJ1:A");
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x002619CC File Offset: 0x0025FBCC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FRMSJ1:I", this.a);
		info.AddValue("FRMSJ1:A", this.b);
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x00261A00 File Offset: 0x0025FC00
	public string a()
	{
		return this.b;
	}

	// Token: 0x0600570E RID: 22286 RVA: 0x00261A08 File Offset: 0x0025FC08
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x00261A14 File Offset: 0x0025FC14
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x00261A1C File Offset: 0x0025FC1C
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x00261A28 File Offset: 0x0025FC28
	public eiw()
	{
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x00261A34 File Offset: 0x0025FC34
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		c1a c1a = null;
		if (A_0 != null)
		{
			c1a = A_0.Zone;
		}
		if (c1a == null && A_1 != null)
		{
			c1a = A_1.Zone;
		}
		if (c1a != null)
		{
			if (this.a != null)
			{
				aud aud = null;
				if (this.b != null)
				{
					aud = c1a.n(this.b);
				}
				else if (A_1 != null)
				{
					aud = A_1.Area;
				}
				if (aud != null)
				{
					c5x = (new ar7(this.a.Value, aud).ao() as c5x);
				}
			}
			else
			{
				c5x = (A_1 as c5x);
			}
			if (c5x != null)
			{
				dvp aspect = c5x.GetAspect<dvp>();
				if (aspect != null)
				{
					aspect.aqc(true);
				}
			}
		}
	}

	// Token: 0x04002344 RID: 9028
	private new Guid? a;

	// Token: 0x04002345 RID: 9029
	private string b;
}
