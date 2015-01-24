// Shader created with Shader Forge v1.04 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.04;sub:START;pass:START;ps:flbk:,lico:1,lgpr:1,nrmq:1,limd:1,uamb:True,mssp:True,lmpd:False,lprd:False,rprd:False,enco:False,frtr:True,vitr:True,dbil:False,rmgx:True,rpth:0,hqsc:True,hqlp:False,tesm:0,blpr:0,bsrc:3,bdst:7,culm:0,dpts:2,wrdp:True,dith:2,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,ofsf:0,ofsu:0,f2p0:False;n:type:ShaderForge.SFN_Final,id:0,x:34902,y:32713,varname:node_0,prsc:2|diff-5866-OUT,emission-7296-OUT,disp-372-OUT,tess-2575-OUT;n:type:ShaderForge.SFN_Color,id:1196,x:33703,y:32757,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_1196,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:2575,x:34041,y:33196,ptovrint:False,ptlb:TesselationValue,ptin:_TesselationValue,varname:node_2575,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:5480,x:33472,y:32966,varname:node_5480,prsc:2,ntxv:0,isnm:False|UVIN-1429-OUT,TEX-7567-TEX;n:type:ShaderForge.SFN_Tex2d,id:4613,x:33716,y:32570,varname:node_4613,prsc:2,ntxv:0,isnm:False|TEX-730-TEX;n:type:ShaderForge.SFN_Multiply,id:5866,x:34379,y:32627,varname:node_5866,prsc:2|A-4613-RGB,B-1196-RGB;n:type:ShaderForge.SFN_Tex2dAsset,id:7567,x:33327,y:32832,ptovrint:False,ptlb:DisplacementTex,ptin:_DisplacementTex,varname:node_7567,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:4741,x:33132,y:33197,varname:node_4741,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:1429,x:33363,y:33272,varname:node_1429,prsc:2|A-4741-UVOUT,B-7871-OUT;n:type:ShaderForge.SFN_Time,id:8766,x:33076,y:33380,varname:node_8766,prsc:2;n:type:ShaderForge.SFN_Tex2dAsset,id:730,x:33398,y:32565,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_730,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:7686,x:33685,y:33199,ptovrint:False,ptlb:AmbientColor,ptin:_AmbientColor,varname:node_7686,prsc:2,glob:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Fresnel,id:3941,x:33646,y:33420,varname:node_3941,prsc:2|EXP-2937-OUT;n:type:ShaderForge.SFN_Multiply,id:2417,x:33876,y:33375,varname:node_2417,prsc:2|A-7686-RGB,B-6310-OUT;n:type:ShaderForge.SFN_Multiply,id:6310,x:33826,y:33476,varname:node_6310,prsc:2|A-3941-OUT,B-609-OUT;n:type:ShaderForge.SFN_ValueProperty,id:609,x:33630,y:33616,ptovrint:False,ptlb:RimScale,ptin:_RimScale,varname:node_609,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:2937,x:33450,y:33481,ptovrint:False,ptlb:RimExponent,ptin:_RimExponent,varname:node_2937,prsc:2,glob:False,v1:3;n:type:ShaderForge.SFN_Add,id:7296,x:34096,y:33281,varname:node_7296,prsc:2|A-7686-RGB,B-2417-OUT;n:type:ShaderForge.SFN_Multiply,id:7871,x:33259,y:33464,varname:node_7871,prsc:2|A-8766-T,B-5396-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5396,x:33038,y:33544,ptovrint:False,ptlb:FlameSpeed,ptin:_FlameSpeed,varname:node_5396,prsc:2,glob:False,v1:1;n:type:ShaderForge.SFN_Multiply,id:171,x:33818,y:32955,varname:node_171,prsc:2|A-5480-RGB,B-6661-XYZ;n:type:ShaderForge.SFN_Vector4Property,id:6661,x:33650,y:33016,ptovrint:False,ptlb:DisplacementDirection,ptin:_DisplacementDirection,varname:node_6661,prsc:2,glob:False,v1:1,v2:0,v3:0,v4:0;n:type:ShaderForge.SFN_NormalVector,id:9849,x:33926,y:32817,prsc:2,pt:False;n:type:ShaderForge.SFN_Vector3,id:8391,x:33968,y:33024,varname:node_8391,prsc:2,v1:0,v2:-1,v3:0;n:type:ShaderForge.SFN_Multiply,id:688,x:34170,y:32838,varname:node_688,prsc:2|A-9849-OUT,B-8391-OUT;n:type:ShaderForge.SFN_Clamp01,id:5653,x:34379,y:32800,varname:node_5653,prsc:2|IN-688-OUT;n:type:ShaderForge.SFN_Lerp,id:372,x:34621,y:33030,varname:node_372,prsc:2|A-171-OUT,B-2779-OUT,T-5653-OUT;n:type:ShaderForge.SFN_Vector1,id:2779,x:34306,y:33131,varname:node_2779,prsc:2,v1:0;proporder:1196-2575-7567-730-7686-609-2937-5396-6661;pass:END;sub:END;*/

Shader "GGJ/FlameShader" {
    Properties {
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _TesselationValue ("TesselationValue", Float ) = 1
        _DisplacementTex ("DisplacementTex", 2D) = "white" {}
        _MainTex ("MainTex", 2D) = "white" {}
        _AmbientColor ("AmbientColor", Color) = (0.5,0.5,0.5,1)
        _RimScale ("RimScale", Float ) = 1
        _RimExponent ("RimExponent", Float ) = 3
        _FlameSpeed ("FlameSpeed", Float ) = 1
        _DisplacementDirection ("DisplacementDirection", Vector) = (1,0,0,0)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "ForwardBase"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 5.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _TesselationValue;
            uniform sampler2D _DisplacementTex; uniform float4 _DisplacementTex_ST;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _AmbientColor;
            uniform float _RimScale;
            uniform float _RimExponent;
            uniform float _FlameSpeed;
            uniform float4 _DisplacementDirection;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_8766 = _Time + _TimeEditor;
                    float2 node_1429 = (v.texcoord0+(node_8766.g*_FlameSpeed));
                    float4 node_5480 = tex2Dlod(_DisplacementTex,float4(TRANSFORM_TEX(node_1429, _DisplacementTex),0.0,0));
                    float node_2779 = 0.0;
                    float3 node_688 = (v.normal*float3(0,-1,0));
                    v.vertex.xyz += lerp((node_5480.rgb*_DisplacementDirection.rgb),float3(node_2779,node_2779,node_2779),saturate(node_688));
                }
                float Tessellation(TessVertex v){
                    return _TesselationValue;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 indirectDiffuse = float3(0,0,0);
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float4 node_4613 = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuse = (directDiffuse + indirectDiffuse) * (node_4613.rgb*_Color.rgb);
////// Emissive:
                float3 emissive = (_AmbientColor.rgb+(_AmbientColor.rgb*(pow(1.0-max(0,dot(normalDirection, viewDirection)),_RimExponent)*_RimScale)));
/// Final Color:
                float3 finalColor = diffuse + emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ForwardAdd"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            Fog { Color (0,0,0,0) }
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 5.0
            uniform float4 _LightColor0;
            uniform float4 _TimeEditor;
            uniform float4 _Color;
            uniform float _TesselationValue;
            uniform sampler2D _DisplacementTex; uniform float4 _DisplacementTex_ST;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _AmbientColor;
            uniform float _RimScale;
            uniform float _RimExponent;
            uniform float _FlameSpeed;
            uniform float4 _DisplacementDirection;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.posWorld = mul(_Object2World, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_8766 = _Time + _TimeEditor;
                    float2 node_1429 = (v.texcoord0+(node_8766.g*_FlameSpeed));
                    float4 node_5480 = tex2Dlod(_DisplacementTex,float4(TRANSFORM_TEX(node_1429, _DisplacementTex),0.0,0));
                    float node_2779 = 0.0;
                    float3 node_688 = (v.normal*float3(0,-1,0));
                    v.vertex.xyz += lerp((node_5480.rgb*_DisplacementDirection.rgb),float3(node_2779,node_2779,node_2779),saturate(node_688));
                }
                float Tessellation(TessVertex v){
                    return _TesselationValue;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float4 node_4613 = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float3 diffuse = directDiffuse * (node_4613.rgb*_Color.rgb);
/// Final Color:
                float3 finalColor = diffuse;
                return fixed4(finalColor * 1,0);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCollector"
            Tags {
                "LightMode"="ShadowCollector"
            }
            
            Fog {Mode Off}
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCOLLECTOR
            #define SHADOW_COLLECTOR_PASS
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcollector
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 5.0
            uniform float4 _TimeEditor;
            uniform float _TesselationValue;
            uniform sampler2D _DisplacementTex; uniform float4 _DisplacementTex_ST;
            uniform float _FlameSpeed;
            uniform float4 _DisplacementDirection;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_COLLECTOR;
                float2 uv0 : TEXCOORD5;
                float3 normalDir : TEXCOORD6;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_COLLECTOR(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_8766 = _Time + _TimeEditor;
                    float2 node_1429 = (v.texcoord0+(node_8766.g*_FlameSpeed));
                    float4 node_5480 = tex2Dlod(_DisplacementTex,float4(TRANSFORM_TEX(node_1429, _DisplacementTex),0.0,0));
                    float node_2779 = 0.0;
                    float3 node_688 = (v.normal*float3(0,-1,0));
                    v.vertex.xyz += lerp((node_5480.rgb*_DisplacementDirection.rgb),float3(node_2779,node_2779,node_2779),saturate(node_688));
                }
                float Tessellation(TessVertex v){
                    return _TesselationValue;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                SHADOW_COLLECTOR_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Cull Off
            Offset 1, 1
            
            Fog {Mode Off}
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers gles xbox360 ps3 flash 
            #pragma target 5.0
            uniform float4 _TimeEditor;
            uniform float _TesselationValue;
            uniform sampler2D _DisplacementTex; uniform float4 _DisplacementTex_ST;
            uniform float _FlameSpeed;
            uniform float4 _DisplacementDirection;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = mul(_Object2World, float4(v.normal,0)).xyz;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                void displacement (inout VertexInput v){
                    float4 node_8766 = _Time + _TimeEditor;
                    float2 node_1429 = (v.texcoord0+(node_8766.g*_FlameSpeed));
                    float4 node_5480 = tex2Dlod(_DisplacementTex,float4(TRANSFORM_TEX(node_1429, _DisplacementTex),0.0,0));
                    float node_2779 = 0.0;
                    float3 node_688 = (v.normal*float3(0,-1,0));
                    v.vertex.xyz += lerp((node_5480.rgb*_DisplacementDirection.rgb),float3(node_2779,node_2779,node_2779),saturate(node_688));
                }
                float Tessellation(TessVertex v){
                    return _TesselationValue;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    displacement(v);
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            fixed4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
/////// Vectors:
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
