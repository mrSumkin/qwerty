using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200108B RID: 4235
[eiz("SESJ0")]
[Serializable]
public sealed class dr5 : cze, ISerializable
{
	// Token: 0x06005857 RID: 22615 RVA: 0x002658B4 File Offset: 0x00263AB4
	private dr5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("SESJ0:I", typeof(Guid?));
		this.c = A_0.GetString("SESJ0:A");
		this.a = (Vector3)A_0.GetValue("SESJ0:L", typeof(Vector3));
	}

	// Token: 0x06005858 RID: 22616 RVA: 0x0026591C File Offset: 0x00263B1C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SESJ0:I", this.b);
		info.AddValue("SESJ0:A", this.c);
		info.AddValue("SESJ0:L", this.a);
	}

	// Token: 0x06005859 RID: 22617 RVA: 0x00265970 File Offset: 0x00263B70
	public Vector3 c()
	{
		return this.a;
	}

	// Token: 0x0600585A RID: 22618 RVA: 0x00265978 File Offset: 0x00263B78
	public void a(Vector3 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600585B RID: 22619 RVA: 0x00265984 File Offset: 0x00263B84
	public string a()
	{
		return this.c;
	}

	// Token: 0x0600585C RID: 22620 RVA: 0x0026598C File Offset: 0x00263B8C
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600585D RID: 22621 RVA: 0x00265998 File Offset: 0x00263B98
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x0600585E RID: 22622 RVA: 0x002659A0 File Offset: 0x00263BA0
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600585F RID: 22623 RVA: 0x002659AC File Offset: 0x00263BAC
	public dr5()
	{
	}

	// Token: 0x06005860 RID: 22624 RVA: 0x002659B4 File Offset: 0x00263BB4
	public dr5(Vector3 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005861 RID: 22625 RVA: 0x002659C4 File Offset: 0x00263BC4
	public sealed override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = null;
		if (this.b != null)
		{
			aud aud = null;
			if (this.c != null)
			{
				b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
				if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
				{
					aud = serviceOrThrow.yn().Zones[0].n(this.c);
				}
			}
			else if (A_1 != null)
			{
				aud = A_1.Area;
			}
			if (aud != null)
			{
				c5x = (new ar7(this.b.Value, aud).ao() as c5x);
			}
		}
		else
		{
			c5x = (A_1 as c5x);
		}
		if (c5x != null)
		{
			c5x.Size = this.a;
		}
	}

	// Token: 0x0400239D RID: 9117
	private new Vector3 a;

	// Token: 0x0400239E RID: 9118
	private Guid? b;

	// Token: 0x0400239F RID: 9119
	private string c;
}
