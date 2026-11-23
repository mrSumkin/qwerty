using System;
using System.Runtime.Serialization;

// Token: 0x02000156 RID: 342
[eiz("SC1")]
[Serializable]
public class dl8 : j4, ISerializable
{
	// Token: 0x0600087E RID: 2174 RVA: 0x00023C98 File Offset: 0x00021E98
	protected dl8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = A_0.GetString("SC1:V");
			if (ell.b() >= 25)
			{
				this.b = A_0.GetBoolean("SC1:I");
				return;
			}
		}
		else
		{
			if (base.GetType() == typeof(dl8))
			{
				this.a = A_0.GetString("_Value");
				return;
			}
			this.a = A_0.GetString("StringCondition+_Value");
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00023D24 File Offset: 0x00021F24
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SC1:V", this.a);
		info.AddValue("SC1:I", this.b);
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00023D50 File Offset: 0x00021F50
	public string a()
	{
		return this.a;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00023D58 File Offset: 0x00021F58
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00023D64 File Offset: 0x00021F64
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00023D6C File Offset: 0x00021F6C
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00023D78 File Offset: 0x00021F78
	public dl8()
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00023D84 File Offset: 0x00021F84
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		object obj = null;
		try
		{
			obj = d8z.a(A_0, A_1, base.d());
		}
		catch
		{
			if (!base.c())
			{
				throw;
			}
		}
		bool flag = (obj == null && this.a == null) || (!(obj == null ^ this.a == null) && obj.ToString().Equals(this.a));
		return flag ^ this.b;
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00023E18 File Offset: 0x00022018
	public override bool h5(string A_0, bool A_1)
	{
		return base.h5(A_0, A_1) || (!string.IsNullOrEmpty(this.a) && this.a.IndexOf(A_0, A_1 ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase) != -1);
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00023E68 File Offset: 0x00022068
	public override string ToString()
	{
		if (this.b)
		{
			return string.Format("{0} != {1}", base.d(), this.a);
		}
		return string.Format("{0} == {1}", base.d(), this.a);
	}

	// Token: 0x040005AF RID: 1455
	private string a;

	// Token: 0x040005B0 RID: 1456
	private bool b;
}
