using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010C9 RID: 4297
[eiz("STFM")]
[Serializable]
public sealed class bcy : cze, ISerializable
{
	// Token: 0x06005A7F RID: 23167 RVA: 0x002710A4 File Offset: 0x0026F2A4
	private bcy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (Guid?)A_0.GetValue("STFM:I", typeof(Guid?));
		this.c = A_0.GetString("STFM:A");
		this.a = (A_0.GetValue("STFM:M", typeof(bjp)) as bjp);
	}

	// Token: 0x06005A80 RID: 23168 RVA: 0x00271118 File Offset: 0x0026F318
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("STFM:I", this.b);
		info.AddValue("STFM:A", this.c);
		info.AddValue("STFM:M", this.a);
	}

	// Token: 0x06005A81 RID: 23169 RVA: 0x00271168 File Offset: 0x0026F368
	public bjp a()
	{
		return this.a;
	}

	// Token: 0x06005A82 RID: 23170 RVA: 0x00271170 File Offset: 0x0026F370
	public void a(bjp A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005A83 RID: 23171 RVA: 0x0027117C File Offset: 0x0026F37C
	public string c()
	{
		return this.c;
	}

	// Token: 0x06005A84 RID: 23172 RVA: 0x00271184 File Offset: 0x0026F384
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06005A85 RID: 23173 RVA: 0x00271190 File Offset: 0x0026F390
	public Guid? b()
	{
		return this.b;
	}

	// Token: 0x06005A86 RID: 23174 RVA: 0x00271198 File Offset: 0x0026F398
	public void a(Guid? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06005A87 RID: 23175 RVA: 0x002711A4 File Offset: 0x0026F3A4
	public bcy()
	{
	}

	// Token: 0x06005A88 RID: 23176 RVA: 0x002711B8 File Offset: 0x0026F3B8
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
			if (this.a != null)
			{
				c5x.TileFormationModifiers = new bjp(this.a.b);
			}
			else
			{
				c5x.l.Clear();
			}
			c5x.z();
		}
	}

	// Token: 0x0400243E RID: 9278
	private new bjp a = new bjp();

	// Token: 0x0400243F RID: 9279
	private Guid? b;

	// Token: 0x04002440 RID: 9280
	private string c;
}
