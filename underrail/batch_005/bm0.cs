using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FC6 RID: 4038
[eiz("PNC")]
[Serializable]
public sealed class bm0 : dnh, ISerializable
{
	// Token: 0x060052F4 RID: 21236 RVA: 0x0024F4F4 File Offset: 0x0024D6F4
	private bm0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("PNC:I");
		this.b = A_0.GetBoolean("PNC:IWN");
		this.c = A_0.GetString("PNC:PN");
		di7.ReadList<string>("PNC:PNL", ref this.d, A_0);
	}

	// Token: 0x060052F5 RID: 21237 RVA: 0x0024F558 File Offset: 0x0024D758
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PNC:I", this.a);
		info.AddValue("PNC:IWN", this.b);
		info.AddValue("PNC:PN", this.c);
		di7.WriteList<string>("PNC:PNL", this.d, info);
	}

	// Token: 0x060052F6 RID: 21238 RVA: 0x0024F5B4 File Offset: 0x0024D7B4
	public bool d()
	{
		return this.a;
	}

	// Token: 0x060052F7 RID: 21239 RVA: 0x0024F5BC File Offset: 0x0024D7BC
	public void b(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052F8 RID: 21240 RVA: 0x0024F5C8 File Offset: 0x0024D7C8
	public bool a()
	{
		return this.b;
	}

	// Token: 0x060052F9 RID: 21241 RVA: 0x0024F5D0 File Offset: 0x0024D7D0
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052FA RID: 21242 RVA: 0x0024F5DC File Offset: 0x0024D7DC
	public string c()
	{
		return this.c;
	}

	// Token: 0x060052FB RID: 21243 RVA: 0x0024F5E4 File Offset: 0x0024D7E4
	public void a(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060052FC RID: 21244 RVA: 0x0024F5F0 File Offset: 0x0024D7F0
	public List<string> b()
	{
		return this.d;
	}

	// Token: 0x060052FD RID: 21245 RVA: 0x0024F5F8 File Offset: 0x0024D7F8
	public void a(List<string> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060052FE RID: 21246 RVA: 0x0024F604 File Offset: 0x0024D804
	public bm0()
	{
	}

	// Token: 0x060052FF RID: 21247 RVA: 0x0024F618 File Offset: 0x0024D818
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null)
		{
			string text = serviceOrThrow.aqu().v().Name.ToUpperInvariant();
			if (this.d.Count > 0)
			{
				using (List<string>.Enumerator enumerator = this.d.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text2 = enumerator.Current;
						if (this.b && text == text2.ToUpperInvariant())
						{
							flag = true;
							break;
						}
						if (!this.b && text.Contains(text2.ToUpperInvariant()))
						{
							flag = true;
							break;
						}
					}
					goto IL_FE;
				}
			}
			if (this.b && text == this.c.ToUpperInvariant())
			{
				flag = true;
			}
			else if (!this.b && text.Contains(this.c.ToUpperInvariant()))
			{
				flag = true;
			}
		}
		IL_FE:
		return flag ^ this.a;
	}

	// Token: 0x040021EE RID: 8686
	private bool a;

	// Token: 0x040021EF RID: 8687
	private bool b;

	// Token: 0x040021F0 RID: 8688
	private string c;

	// Token: 0x040021F1 RID: 8689
	private List<string> d = new List<string>();
}
