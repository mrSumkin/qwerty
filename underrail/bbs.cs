using System;
using System.Xml.Serialization;

// Token: 0x0200006B RID: 107
[eiz("ESM")]
[Serializable]
public enum bbs
{
	// Token: 0x0400036C RID: 876
	[XmlEnum("Immediate")]
	a,
	// Token: 0x0400036D RID: 877
	[XmlEnum("FadeOut")]
	b,
	// Token: 0x0400036E RID: 878
	[XmlEnum("WrapUp")]
	c
}
