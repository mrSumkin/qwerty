using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001319 RID: 4889
[a(typeof(j7))]
[eiz("LCAEA")]
[Serializable]
public sealed class bn5 : j7, ISerializable
{
	// Token: 0x06006E13 RID: 28179 RVA: 0x002E0318 File Offset: 0x002DE518
	private bn5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LCAEA:DM");
			this.b = A_0.GetBoolean("LCAEA:ACBQA");
			if (ell.a() >= 80)
			{
				this.c = A_0.GetBoolean("LCAEA:F");
			}
			else
			{
				this.c = true;
			}
			if (ell.a() >= 116)
			{
				this.d = A_0.GetString("LCAEA:O");
				return;
			}
		}
		else
		{
			this.a = A_0.GetString("_DialogModel");
			try
			{
				this.b = A_0.GetBoolean("LCAEA:ACB");
			}
			catch
			{
			}
		}
	}

	// Token: 0x06006E14 RID: 28180 RVA: 0x002E03E4 File Offset: 0x002DE5E4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LCAEA:DM", this.a);
		info.AddValue("LCAEA:ACBQA", this.b);
		info.AddValue("LCAEA:F", this.c);
		info.AddValue("LCAEA:O", this.d);
	}

	// Token: 0x06006E15 RID: 28181 RVA: 0x002E0440 File Offset: 0x002DE640
	public override string e9()
	{
		if (!string.IsNullOrEmpty(this.d))
		{
			return this.d;
		}
		if (base.a8() != null && base.a8().h.b != null && base.a8().h.b.aa() != null)
		{
			return base.a8().h.b.aa().Id;
		}
		return null;
	}

	// Token: 0x06006E16 RID: 28182 RVA: 0x002E04BC File Offset: 0x002DE6BC
	public override string fa()
	{
		if (base.a8() != null && base.a8().h.b != null && base.a8().h.b.aa() != null)
		{
			return base.a8().h.b.aa().LocalizedName;
		}
		return null;
	}

	// Token: 0x06006E17 RID: 28183 RVA: 0x002E0520 File Offset: 0x002DE720
	public override string fb()
	{
		if (base.a8() != null && base.a8().h.b != null && base.a8().h.b.aa() != null)
		{
			return base.a8().h.b.aa().bd;
		}
		return null;
	}

	// Token: 0x06006E18 RID: 28184 RVA: 0x002E0584 File Offset: 0x002DE784
	public override Color? fc()
	{
		if (base.a8() != null && base.a8().h.b != null && base.a8().h.b.aa() != null)
		{
			return new Color?(base.a8().h.b.aa().Color);
		}
		return null;
	}

	// Token: 0x06006E19 RID: 28185 RVA: 0x002E05F4 File Offset: 0x002DE7F4
	public override string fd()
	{
		return this.a;
	}

	// Token: 0x06006E1A RID: 28186 RVA: 0x002E05FC File Offset: 0x002DE7FC
	public string d()
	{
		return this.a;
	}

	// Token: 0x06006E1B RID: 28187 RVA: 0x002E0604 File Offset: 0x002DE804
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006E1C RID: 28188 RVA: 0x002E0610 File Offset: 0x002DE810
	public bool e()
	{
		return this.b;
	}

	// Token: 0x06006E1D RID: 28189 RVA: 0x002E0618 File Offset: 0x002DE818
	public void b(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006E1E RID: 28190 RVA: 0x002E0624 File Offset: 0x002DE824
	public bool b()
	{
		return this.c;
	}

	// Token: 0x06006E1F RID: 28191 RVA: 0x002E062C File Offset: 0x002DE82C
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006E20 RID: 28192 RVA: 0x002E0638 File Offset: 0x002DE838
	public string a()
	{
		return this.d;
	}

	// Token: 0x06006E21 RID: 28193 RVA: 0x002E0640 File Offset: 0x002DE840
	public void a(string A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06006E22 RID: 28194 RVA: 0x002E064C File Offset: 0x002DE84C
	public bn5(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x04002D05 RID: 11525
	private new string a;

	// Token: 0x04002D06 RID: 11526
	private bool b;

	// Token: 0x04002D07 RID: 11527
	private bool c = true;

	// Token: 0x04002D08 RID: 11528
	private string d;
}
