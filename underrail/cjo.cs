using System;
using System.Runtime.Serialization;

// Token: 0x020004DE RID: 1246
[eiz("R02")]
[Serializable]
public sealed class cjo : dnh, ISerializable
{
	// Token: 0x06002010 RID: 8208 RVA: 0x000AED34 File Offset: 0x000ACF34
	private cjo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("R02:M");
		this.b = A_0.GetInt32("R02:X");
		if (ell.b() >= 545)
		{
			this.c = A_0.GetString("R02:P");
			this.d = A_0.GetBoolean("R02:D");
		}
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x000AED9C File Offset: 0x000ACF9C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("R02:M", this.a);
		info.AddValue("R02:X", this.b);
		info.AddValue("R02:P", this.c);
		info.AddValue("R02:D", this.d);
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x000AEDF8 File Offset: 0x000ACFF8
	public int c()
	{
		return this.a;
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000AEE00 File Offset: 0x000AD000
	public void b(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000AEE0C File Offset: 0x000AD00C
	public int a()
	{
		return this.b;
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000AEE14 File Offset: 0x000AD014
	public void a(int A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000AEE20 File Offset: 0x000AD020
	public string b()
	{
		return this.c;
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x000AEE28 File Offset: 0x000AD028
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000AEE34 File Offset: 0x000AD034
	public cjo(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000AEE44 File Offset: 0x000AD044
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (A_1 != null)
		{
			string name = (!string.IsNullOrEmpty(this.c)) ? this.c : "persistedInt";
			int? primitivePropertyValue;
			if (this.d)
			{
				primitivePropertyValue = new int?(A_1.GetPrimitivePropertyValue<int>(name, new int?(0)).Value);
			}
			else
			{
				primitivePropertyValue = A_1.GetPrimitivePropertyValue<int>(name, null);
			}
			if (primitivePropertyValue != null)
			{
				int? num = primitivePropertyValue;
				int num2 = this.c();
				if (num.GetValueOrDefault() >= num2 & num != null)
				{
					num = primitivePropertyValue;
					num2 = this.a();
					return num.GetValueOrDefault() <= num2 & num != null;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x040013F9 RID: 5113
	private int a;

	// Token: 0x040013FA RID: 5114
	private int b;

	// Token: 0x040013FB RID: 5115
	private string c;

	// Token: 0x040013FC RID: 5116
	private bool d;
}
