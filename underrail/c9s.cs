using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x02000A4B RID: 2635
[eiz("CCROBC")]
[Serializable]
public sealed class c9s : cze, ISerializable
{
	// Token: 0x06003E62 RID: 15970 RVA: 0x00178AB0 File Offset: 0x00176CB0
	private c9s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("CCROBC:TL");
		this.b = A_0.GetBoolean("CCROBC:SU");
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x00178ADC File Offset: 0x00176CDC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CCROBC:TL", this.a);
		info.AddValue("CCROBC:SU", this.b);
	}

	// Token: 0x06003E64 RID: 15972 RVA: 0x00178B08 File Offset: 0x00176D08
	public string a()
	{
		return this.a;
	}

	// Token: 0x06003E65 RID: 15973 RVA: 0x00178B10 File Offset: 0x00176D10
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x00178B1C File Offset: 0x00176D1C
	public bool b()
	{
		return this.b;
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x00178B24 File Offset: 0x00176D24
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x00178B30 File Offset: 0x00176D30
	public c9s()
	{
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x00178B3C File Offset: 0x00176D3C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow != null && c5x != null)
		{
			string text = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dun_ccResOffice_actualSequence");
			if (text == null)
			{
				int num = cuo.a.Next(0, 3);
				if (num != 1)
				{
					if (num != 2)
					{
						text = "LSLSLLLSLLSSSLS";
					}
					else
					{
						text = "SSSLSLSLSLLLSLL";
					}
				}
				else
				{
					text = "LLSLLSSSLSLSLSL";
				}
				serviceOrThrow.aqu().r()["loc_dun_ccResOffice_actualSequence"] = text;
				return;
			}
			string classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dun_ccResOffice_currentSequence");
			int num2;
			if (classPropertyValue == null || classPropertyValue.Equals("  "))
			{
				num2 = 0;
				serviceOrThrow.aqu().r()["loc_dun_ccResOffice_currentSequence"] = "";
			}
			else
			{
				num2 = serviceOrThrow.aqu().r().GetClassPropertyValue<string>("loc_dun_ccResOffice_currentSequence").Length;
			}
			string str = this.a;
			if (this.b)
			{
				if (num2 == 15 && text.Equals(classPropertyValue))
				{
					serviceOrThrow.aqu().r()["loc_dun_ccResOffice_BotConsoleSuccess"] = true;
					c5x c5x2 = new ar7(new Guid("333efd42-02ca-43f3-9cf6-7361da5d6f6d"), c5x.Area).ao() as c5x;
					if (c5x2 != null)
					{
						d2b aspect = c5x2.GetAspect<d2b>();
						if (aspect != null && aspect.n() && aspect.e())
						{
							aspect.e(false);
							c5x2.p.b.a[1].b = new Point(1, 0);
						}
					}
					return;
				}
				serviceOrThrow.aqu().r()["loc_dun_ccResOffice_BotConsoleSuccess"] = false;
				return;
			}
			else if (num2 < 20)
			{
				PropertyCollection propertyCollection = serviceOrThrow.aqu().r();
				PropertyCollection propertyCollection2 = propertyCollection;
				string name = "loc_dun_ccResOffice_currentSequence";
				object obj = propertyCollection["loc_dun_ccResOffice_currentSequence"];
				propertyCollection2[name] = ((obj != null) ? obj.ToString() : null) + str;
			}
		}
	}

	// Token: 0x04001BB8 RID: 7096
	private new string a;

	// Token: 0x04001BB9 RID: 7097
	private bool b;
}
