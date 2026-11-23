using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Ouroboros.Common.Data;

// Token: 0x0200067B RID: 1659
[eiz("LR")]
[TypeConverter(typeof(bf7))]
[Serializable]
public class c2w : ISerializable
{
	// Token: 0x06002A40 RID: 10816 RVA: 0x000EE354 File Offset: 0x000EC554
	protected c2w(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("LR:LI");
			this.b = A_0.GetString("LR:EI");
			return;
		}
		if (base.GetType() == typeof(c2w))
		{
			this.a = A_0.GetString("_LocaleId");
			this.b = A_0.GetString("_EntranceId");
			return;
		}
		this.a = A_0.GetString("LocaleReference+_LocaleId");
		this.b = A_0.GetString("LocaleReference+_EntranceId");
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x000EE3F4 File Offset: 0x000EC5F4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("LR:LI", this.a);
		info.AddValue("LR:EI", this.b);
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x000EE418 File Offset: 0x000EC618
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x000EE420 File Offset: 0x000EC620
	public void b(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x000EE42C File Offset: 0x000EC62C
	public string c()
	{
		return this.b;
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x000EE434 File Offset: 0x000EC634
	public void c(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x000EE440 File Offset: 0x000EC640
	public c2w()
	{
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x000EE448 File Offset: 0x000EC648
	public c2w(string A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x000EE460 File Offset: 0x000EC660
	public override string ToString()
	{
		return this.a + ":" + this.b;
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x000EE47C File Offset: 0x000EC67C
	public static c2w a(string A_0)
	{
		string[] array = A_0.Split(new char[]
		{
			':'
		});
		c2w c2w = new c2w();
		if (array.Length != 0)
		{
			c2w.a = array[0];
		}
		if (array.Length > 1)
		{
			c2w.c(array[1]);
		}
		return c2w;
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x000EE4CC File Offset: 0x000EC6CC
	public void a(cyt A_0)
	{
		if (A_0 != null)
		{
			bq8 a_ = A_0.e();
			this.a = this.a(a_, this.a);
			this.b = this.a(a_, this.b);
		}
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x000EE50C File Offset: 0x000EC70C
	public c2w a()
	{
		return new c2w(this.a, this.b);
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x000EE520 File Offset: 0x000EC720
	private string a(bq8 A_0, string A_1)
	{
		if (!string.IsNullOrEmpty(A_1) && A_1.StartsWith("$(") && A_1.EndsWith(")") && A_1.Length > 3)
		{
			string a_ = A_1.Substring(2, A_1.Length - 3);
			try
			{
				string text = d8z.a(A_0, new PropertyCollection(), a_) as string;
				if (text != null)
				{
					return text;
				}
			}
			catch
			{
			}
			return A_1;
		}
		return A_1;
	}

	// Token: 0x040016FF RID: 5887
	private string a;

	// Token: 0x04001700 RID: 5888
	private string b;
}
