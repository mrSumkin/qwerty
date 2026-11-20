using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020010AD RID: 4269
[eiz("ENFEJ")]
[Serializable]
public sealed class er8 : cze, ISerializable
{
	// Token: 0x060059AA RID: 22954 RVA: 0x0026BC4C File Offset: 0x00269E4C
	private er8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid?)A_0.GetValue("ENFEJ:I", typeof(Guid?));
		this.b = A_0.GetString("ENFEJ:A");
		this.c = A_0.GetDouble("ENFEJ:V");
	}

	// Token: 0x060059AB RID: 22955 RVA: 0x0026BCA4 File Offset: 0x00269EA4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ENFEJ:V", this.c);
		info.AddValue("ENFEJ:I", this.a);
		info.AddValue("ENFEJ:A", this.b);
	}

	// Token: 0x060059AC RID: 22956 RVA: 0x0026BCF4 File Offset: 0x00269EF4
	public double c()
	{
		return this.c;
	}

	// Token: 0x060059AD RID: 22957 RVA: 0x0026BCFC File Offset: 0x00269EFC
	public void a(double A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060059AE RID: 22958 RVA: 0x0026BD08 File Offset: 0x00269F08
	public string a()
	{
		return this.b;
	}

	// Token: 0x060059AF RID: 22959 RVA: 0x0026BD10 File Offset: 0x00269F10
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060059B0 RID: 22960 RVA: 0x0026BD1C File Offset: 0x00269F1C
	public Guid? b()
	{
		return this.a;
	}

	// Token: 0x060059B1 RID: 22961 RVA: 0x0026BD24 File Offset: 0x00269F24
	public void a(Guid? A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060059B2 RID: 22962 RVA: 0x0026BD30 File Offset: 0x00269F30
	public er8()
	{
	}

	// Token: 0x060059B3 RID: 22963 RVA: 0x0026BD38 File Offset: 0x00269F38
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (this.c > 0.0)
		{
			c5x c5x = null;
			if (this.a != null)
			{
				aud aud = null;
				if (this.b != null)
				{
					b4b serviceOrThrow = bpo.GetServiceOrThrow<b4b>();
					if (serviceOrThrow.yn() != null && serviceOrThrow.yn().Zones.Count > 0)
					{
						aud = serviceOrThrow.yn().Zones[0].n(this.b);
					}
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
				eym.a(c5x, this.c);
			}
		}
	}

	// Token: 0x04002403 RID: 9219
	private new Guid? a;

	// Token: 0x04002404 RID: 9220
	private string b;

	// Token: 0x04002405 RID: 9221
	private double c;
}
